﻿using System;
using System.Runtime.InteropServices;
using Numeric = System.Decimal;

namespace Nyang
{

	///深度行情
	[StructLayout(LayoutKind.Sequential)]
	public class Tick
	{
		/// <summary>
		/// 合约代码
		/// </summary>
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string InstrumentID;	//31
		/// <summary>
		/// 最新价
		/// </summary>
		public Numeric LastPrice;
		/// <summary>
		///申买价一
		/// </summary>
		public Numeric BidPrice;
		/// <summary>
		///申买量一
		/// </summary>
		public int BidVolume;
		/// <summary>
		///申卖价一
		/// </summary>
		public Numeric AskPrice;
		/// <summary>
		///申卖量一
		/// </summary>
		public int AskVolume;
		/// <summary>
		///当日均价
		/// </summary>
		public Numeric AveragePrice;
		/// <summary>
		///数量
		/// </summary>
		public int Volume;
		/// <summary>
		///持仓量
		/// </summary>
		public Numeric OpenInterest;
		/// <summary>
		///最后修改时间:yyyyMMdd HH:mm:ss(20141114:日期由主程序处理,因大商所取到的actionday==tradingday)
		/// </summary>
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string UpdateTime;
		/// <summary>
		///最后修改毫秒
		/// </summary>
		public int UpdateMillisec;
		/// <summary>
		///涨停板价
		/// </summary>
		public Numeric UpperLimitPrice;
		/// <summary>
		///跌停板价
		/// </summary>
		public Numeric LowerLimitPrice;
	}
}
