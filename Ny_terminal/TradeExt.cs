﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace Nyang
{
	public partial class TradeExt : CTPTrade
	{
		int _custom = 100000;

		public TradeExt()
		{
			this.OnFrontConnected += (snd, ea) => ShowInfo("connected.");
			this.OnRspUserLogout += (snd, ea) => ShowInfo($"logout:{ea.Value}");

			this.OnRtnOrder += (snd, e) =>
			  {
				  if (!e.Value.IsLocal) return;

				  ShowInfo($"[{e.Value.Custom}]报单({e.Value.StatusMsg})[{e.Value.InstrumentID},{e.Value.Direction},{ e.Value.Offset},{e.Value.LimitPrice},{ e.Value.Volume},剩{ e.Value.VolumeLeft}]");
			  };
			this.OnRtnCancel += (snd, e) =>
			{
				if (!e.Value.IsLocal) return;

				ShowInfo($"[{e.Value.Custom}]报单({e.Value.StatusMsg})[{e.Value.InstrumentID},{e.Value.Direction},{ e.Value.Offset},{e.Value.LimitPrice},{ e.Value.Volume},剩{ e.Value.VolumeLeft}]");
			};
			//this.OnRtnTrade += (snd, e) =>
			//{
			//	ShowInfo($"[OrderID:{e.Value.OrderID}]报单成交[{e.Value.InstrumentID},{e.Value.Direction},{ e.Value.Offset},{e.Value.Price},{ e.Value.Volume}]");
			//};
			this.OnRtnErrOrder += (snd, e) =>
			{
				if (!e.Value.IsLocal) return;

				ShowInfo($"[{e.Value.Custom}]报单错误({e.Value.StatusMsg})[{e.Value.InstrumentID},{e.Value.Direction},{ e.Value.Offset},{e.Value.LimitPrice},{ e.Value.Volume},剩{ e.Value.VolumeLeft}]");
			};

			this.OnRtnExchangeStatus += (snd, e) =>
			{
				if (_listWaitTrading.Count == 0) return;

				if (e.Status == ExchangeStatusType.Trading)
				{
					//处理收盘前未发的委托
					for (int i = 0; i < _listWaitTrading.Count; i++)
					{
						var list = _listWaitTrading[i];
						var inst = (string)list[0];
						if (DicInstrumentField[inst].ProductID == e.Exchange || DicInstrumentField[inst].InstrumentID == e.Exchange || DicInstrumentField[inst].ExchangeID.ToString() == e.Exchange)
						{
							_listWaitTrading.RemoveAt(i--);
							ReqOrderInsert(inst, (DirectionType)list[1], (OffsetType)list[2], (double)list[3], (int)list[4], (OrderType)list[5], (int)list[6], (HedgeType)list[7]);
						}
					}
				}
			};
		}

		public event ShowInfoAction OnInfo
		{
			add { _showInfo += value; }
			remove { _showInfo -= value; }
		}

		public delegate void ShowInfoAction(string msg);
		ShowInfoAction _showInfo;

		private List<object[]> _listWaitTrading = new List<object[]>();

		/// <summary>
		/// 会触发 oninfo 事件
		/// </summary>
		/// <param name="msg"></param>
		private void ShowInfo(string msg) { _showInfo?.Invoke(msg); }

		/// <summary>
		/// 平仓
		/// </summary>
		/// <param name="pInstrument">合约</param>
		/// <param name="pPosiDire">平多/空仓</param>
		/// <param name="pCloseLots">要平的手数</param>
		/// <param name="pTick">合约的行情</param>
		/// <param name="pForce">是否强平(强平用板价发单,否则发对价单)</param>
		/// <param name="pPrice">指定发单价(默认为Nan)</param>
		/// <returns>少平的手数</returns>
		private int ClosePosi(string pInstrument, DirectionType pPosiDire, int pCloseLots, MarketData pTick, bool pForce)
		{
			return close(pInstrument, pPosiDire, pCloseLots, pTick, pForce, double.NaN, _custom++);
		}

		/// <summary>
		/// 限价平仓
		/// </summary>
		/// <param name="pInstrument">合约</param>
		/// <param name="pPosiDire">平多/空仓</param>
		/// <param name="pPrice">指定发单价</param>
		/// <param name="pCloseLots">要平的手数</param>
		/// <param name="pCustom">自定义(不填,程序会取下一个ID)</param>
		/// <returns></returns>
		public int ClosePosi(string pInstrument, DirectionType pPosiDire, double pPrice, int pCloseLots, int pCustom = default(int))
		{
			return close(pInstrument, pPosiDire, pCloseLots, null, false, pPrice, pCustom == default(int) ? _custom++ : pCustom);
		}

		private int close(string pInstrument, DirectionType pPosiDire, int pCloseLots, MarketData pTick, bool pForce, double pPrice, int pCustom)
		{
			PositionField pf;
			if (!DicPositionField.TryGetValue($"{pInstrument}_{pPosiDire}", out pf))
				return pCloseLots;

			var dire = pPosiDire == DirectionType.Buy ? DirectionType.Sell : DirectionType.Buy;
			var price = !double.IsNaN(pPrice) ? pPrice : (dire == DirectionType.Buy ? (pForce ? pTick.UpperLimitPrice : pTick.AskPrice) : (pForce ? pTick.LowerLimitPrice : pTick.BidPrice));  //板价发单
			var volClose = Math.Min(pCloseLots, pf.Position);   //可平量
			var rtn = pCloseLots - volClose;
			if (DicInstrumentField[pInstrument].ExchangeID == Exchange.SHFE && pf.TdPosition > 0)
			{
				var tdClose = Math.Min(pf.TdPosition, volClose);
				ReqOrderInsert(pInstrument, dire, OffsetType.CloseToday, price, tdClose, pCustom: pCustom);
				volClose -= tdClose;
			}
			if (volClose > 0)
			{
				ReqOrderInsert(pInstrument, dire, OffsetType.Close, price, volClose, pCustom: pCustom);
			}
			return rtn;
		}

		public new int ReqOrderInsert(string pInstrument, DirectionType pDirection, OffsetType pOffset, double pPrice, int pVolume, OrderType pType = OrderType.Limit, int pCustom = 0, HedgeType pHedge = HedgeType.Speculation)
		{
			InstrumentField dif;
			ExchangeStatusType es;
			//小节收盘:等待重新开盘
			if (DicInstrumentField.TryGetValue(pInstrument, out dif))
			{
				if (_initFlow)
					pPrice += FloConfig.FirstAddTicks * (pDirection == DirectionType.Buy ? 1 : -1) * dif.PriceTick;
				//限定在涨跌板范围内
				MarketData f;
				if (_q == null || !_q.DicTick.TryGetValue(pInstrument, out f))
				{
					_q.ReqSubscribeMarketData(pInstrument);
					Thread.Sleep(200);
				}
				if (_q == null || !_q.DicTick.TryGetValue(pInstrument, out f))
					ShowInfo($"合约{pInstrument}无行情");
				else
					pPrice = Math.Max(f.LowerLimitPrice, Math.Min(f.UpperLimitPrice, pPrice));

				if (DicExcStatus.TryGetValue(dif.ProductID, out es) || DicExcStatus.TryGetValue(dif.InstrumentID, out es) || DicExcStatus.TryGetValue(dif.ExchangeID.ToString(), out es))
					if (es == ExchangeStatusType.NoTrading)//小节收盘中:待处理
					{
						ShowInfo($"小节收盘,待重新开盘后再发委托:{pInstrument},{pDirection},{ pOffset},{ pPrice},{ pVolume},{pCustom}");
						_listWaitTrading.Add(new object[] { pInstrument, pDirection, pOffset, pPrice, pVolume, pType, pCustom, pHedge });
						return 0;
					}
			}
			return base.ReqOrderInsert(pInstrument, pDirection, pOffset, pPrice, pVolume, pCustom, pType, pHedge);
		}


		private Quote _q = null;

		#region 追单功能
		public FollowConfig FloConfig = new FollowConfig();    //是否为null,处理多次调用
		bool _initFlow = false;   //是否初始化过
		internal string _ServerTrade;

		/// <summary>
		/// 启动追单
		/// </summary>
		/// <param name="q"></param>
		/// <param name="cfg"></param>
		public void StartFollow(Quote q)
		{
			_q = q;
			//FloConfig = cfg;
			ShowInfo("启动追单功能.");
			if (!_initFlow)
			{
				_initFlow = true;
				this.OnRtnOrder += TradeExt_OnRtnOrder;
				this.OnRtnTrade += TradeExt_OnRtnTrade;
				this.OnRtnCancel += TradeExt_OnRtnCancel;
				this.OnRtnErrOrder += TradeExt_OnRtnErrOrder;
			}
		}

		private void TradeExt_OnRtnCancel(object sender, OrderArgs e)
		{
			if (!e.Value.IsLocal) return;

			if (_q == null)
			{
				ShowInfo("请先赋值行情接口");
				return;
			}

			MarketData tick;
			if (!_q.DicTick.TryGetValue(e.Value.InstrumentID, out tick)) return;
			var id = e.Value.Custom + 1;
			var times = e.Value.Custom % 100;
			if (times >= FloConfig.FollowTimes) //达到最大追单次数
			{
				var price = e.Value.Direction == DirectionType.Buy ? tick.UpperLimitPrice : tick.LowerLimitPrice;
				ShowInfo($"[{e.Value.Custom}]达到最大追单次数({FloConfig.FollowTimes},板价追单[custom:{id}][{e.Value.InstrumentID},{e.Value.Direction},{ e.Value.Offset},{ e.Value.Direction},{price},{ e.Value.VolumeLeft}])");
				ReqOrderInsert(e.Value.InstrumentID, e.Value.Direction, e.Value.Offset, price, e.Value.VolumeLeft, OrderType.Limit, id);
			}
			else
			{
				InstrumentField instField;
				if (!DicInstrumentField.TryGetValue(e.Value.InstrumentID, out instField)) return;

				var price = e.Value.Direction == DirectionType.Buy ? (tick.AskPrice + FloConfig.NotFirstAddticks * instField.PriceTick) : (tick.BidPrice - FloConfig.NotFirstAddticks * instField.PriceTick);
				ShowInfo($"[{e.Value.Custom}]第{times - 1}次追单[id:{id}][{e.Value.InstrumentID},{e.Value.Direction},{ e.Value.Offset},{ e.Value.Direction},{price},{ e.Value.VolumeLeft}]");
				ReqOrderInsert(e.Value.InstrumentID, e.Value.Direction, e.Value.Offset, price, e.Value.VolumeLeft, OrderType.Limit, id);
			}
		}

		private void TradeExt_OnRtnOrder(object sender, OrderArgs e)
		{
			if (!e.Value.IsLocal) return;

			if (FloConfig.WaitSecondsAfterOrder == 0) return; //0:不追单
			new Thread((id) =>
			{
				Thread.Sleep(FloConfig.WaitSecondsAfterOrder * 1000);
				ReqOrderAction((string)id);  //直接撤单,如果成功则继续,否则报错则不处理
			}).Start(e.Value.OrderID);
		}

		private void TradeExt_OnRtnTrade(object sender, TradeArgs e)
		{
			OrderField of;
			if (!DicOrderField.TryGetValue(e.Value.OrderID, out of)) return;
			if (!of.IsLocal) return;
		}

		private void TradeExt_OnRtnErrOrder(object sender, ErrOrderArgs e)
		{
			if (!e.Value.IsLocal) return;
		}
		#endregion

	}

	public class FollowConfig
	{
		[DisplayName("  首次偏移跳数")]
		public int FirstAddTicks { get; set; } = 2;
		[DisplayName(" 撤单等待秒数")]
		public int WaitSecondsAfterOrder { get { return _sec; } set { if (value < 1) throw new Exception("此值范围应>=1"); _sec = value; } }
		[DisplayName("*非*首次偏移跳数")]
		public int NotFirstAddticks { get; set; } = 3;
		[DisplayName("追单次数(达到后发市价单)")]
		public int FollowTimes { get; set; } = 3;

		internal List<int> Customs = new List<int>();
		private int _sec = 3;
	}
}


