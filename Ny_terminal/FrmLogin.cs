using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nyang
{
    public partial class FrmLogin : Form
    {
        readonly DataTable _dt = new DataTable("ServerConfig");
        public TradeExt Trade;
        public Quote Quote;
        public string Server;
        private DateTime _logTime = DateTime.MinValue;
        public FrmLogin()
        {
            InitializeComponent();
            Init();
        }
        void Init()
        {
            this.Load += FormLogin_Load;
            //关闭窗体后发生的
            this.FormClosed += FormLogin_FormClosed;
            //this.btn_login.Click += kryptonButtonLogin_Click;
            this.btn_exit.Click += btn_exit_Click;
            //this.button1.Click += Button1_Click;
            this.KeyPress += NextTab;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            //设置列字段,分别为txt,val并以第一个为关键字
            _dt.Columns.Add("txt");
            _dt.Columns.Add("val");
            _dt.PrimaryKey = new[] { _dt.Columns[0] };
            ReadServer();
        }
        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void NextTab(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (this.tbx_pwd.Focused || this.btn_login.Focused)
                {
                    this.btn_login.PerformClick();
                }
                else if (this.tbx_user.Focused)
                    this.tbx_pwd.Focus();
            }
        }

        void ReadServer()
        {
            _dt.Rows.Clear();
            this.cbb_server.Items.Clear();
            if (!File.Exists("server.txt"))
                File.WriteAllText("server.txt", @"模拟,ctp|9999|tcp://180.168.146.187:10000|tcp://180.168.146.187:10010
股指仿真,ctp|1010|tcp://simctp1010.yhqh.com:41205|tcp://simctp1010.yhqh.com:41213", Encoding.GetEncoding("GB2312"));
            var lines = File.ReadAllLines("server.txt", Encoding.GetEncoding("GB2312"));
            this.richTextBox1.Lines = lines;
            foreach (string line in lines)
            {
                if (string.IsNullOrEmpty(line))
                    continue;
                _dt.Rows.Add(line.Split(','));
            }

            foreach (DataRow dr in _dt.Rows)
                this.cbb_server.Items.Add(dr["txt"]);

            //保存的登录信息
            if (File.Exists("login.ini"))
            {
                string[] fs = File.ReadAllLines("login.ini");
                this.cbb_server.Text = fs[0].Split('@')[1];
                this.tbx_user.Text = fs[0].Split('@')[0];
                this.ActiveControl = this.tbx_pwd;
            }
        }

        void trade_OnRtnExchangeStatus(object sender, StatusEventArgs e)
        {
            ShowMsg(e.Exchange + "=>" + e.Status);
        }
        void trade_OnRspUserLogin(object sender, IntEventArgs e)
        {
            if (e.Value == 0)
            {
                ShowMsg("login successed.");
                //Thread.Sleep(1500);
                //交易登录成功后,登录行情
                if (Quote == null)
                    LoginSuccess();
                else
                    Quote.ReqConnect(_ServerQuote);
            }
            else
            {
                ShowMsg("login error:" + e.Value);
                Trade.ReqUserLogout();
                Trade = null;
                Quote = null;
            }
        }

        void trade_OnFrontConnected(object sender, EventArgs e)
        {
            ShowMsg("connected.");
            ((Trade)sender).ReqUserLogin(_Investor, _Password, _Broker);
            ShowMsg("loging ...");
        }

        void quote_OnRspUserLogin(object sender, IntEventArgs e)
        {
            LoginSuccess();
        }

        void quote_OnFrontConnected(object sender, EventArgs e)
        {
            ((Quote)sender).ReqUserLogin(_Investor, _Password, _Broker);
        }

        //登录成功
        void LoginSuccess()
        {
            Trade.OnFrontConnected -= trade_OnFrontConnected;
            Trade.OnRspUserLogin -= trade_OnRspUserLogin;
            Trade.OnRtnExchangeStatus -= trade_OnRtnExchangeStatus;
            if (Quote != null)
            {
                Quote.OnFrontConnected -= quote_OnFrontConnected;
                Quote.OnRspUserLogin -= quote_OnRspUserLogin;
            }

            this.Invoke(new Action(() =>
            {
                Server = this.cbb_server.Text;
                File.WriteAllText("login.ini", _Investor + "@" + Server);
                this.DialogResult = DialogResult.OK;
            }));
        }
        /// <summary>
		/// 消息传递,接口登录过程中有消息返回时被调用.
		/// </summary>
		public Action<string> Msg;
        private string _Broker;
        private string _ServerQuote;
        private string _ServerTrade;
        private string _Investor;
        private string _Password;

        void ShowMsg(string pMsg)
        {
            try
            {
                this.Invoke(new Action(() =>
                {
                    //var parentForm = (FormShadom)this.Owner.ActiveMdiChild;
                    //if (parentForm != null) parentForm.ShowMsg(pMsg);
                    if (Msg != null)
                    {
                        Msg(pMsg);
                    }
                    this.toolStripStatusLabel1.Text = DateTime.Now.ToString("HH:mm:ss") + "|" + pMsg;
                }));
            }
            catch
            {
                // ignored
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if ((DateTime.Now - _logTime).TotalSeconds < 3)
                return;
            _logTime = DateTime.Now;
            ShowMsg("connecting ...");
            string front = (string)_dt.Rows.Find(this.cbb_server.Text)[1];
            string[] fs = front.Split('|');
            _Investor = this.tbx_user.Text;
            _Password = this.tbx_pwd.Text;
            _ServerTrade = fs[2];
            _Broker = fs[1];
            _ServerQuote = fs[3];

            if (!string.IsNullOrEmpty(fs[3]))
            {
                Quote = new CTPQuote();
                Quote.OnFrontConnected += quote_OnFrontConnected;
                Quote.OnRspUserLogin += quote_OnRspUserLogin;
            }

            Trade = new TradeExt();
            Trade.OnFrontConnected += trade_OnFrontConnected;
            Trade.OnRspUserLogin += trade_OnRspUserLogin;
            Trade.OnRtnExchangeStatus += trade_OnRtnExchangeStatus;
            Trade.ReqConnect(_ServerTrade);
       }
    }
}
