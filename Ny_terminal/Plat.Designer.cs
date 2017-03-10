namespace Nyang
{
    partial class Plat
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_account_info = new System.Windows.Forms.Label();
            this.btn_clear_strg_files = new System.Windows.Forms.Button();
            this.btn_load_strgs_file = new System.Windows.Forms.Button();
            this.cbb_strategy_file = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_delete_strg = new System.Windows.Forms.Button();
            this.btn_add_strg = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_run_strg = new System.Windows.Forms.Button();
            this.rbtn_tick = new System.Windows.Forms.RadioButton();
            this.rbtn_K = new System.Windows.Forms.RadioButton();
            this.dtp_over = new System.Windows.Forms.DateTimePicker();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.lbl_over = new System.Windows.Forms.Label();
            this.lbl_start = new System.Windows.Forms.Label();
            this.cbb_interval = new System.Windows.Forms.ComboBox();
            this.cbb_instrument2 = new System.Windows.Forms.ComboBox();
            this.lbl_instrument2 = new System.Windows.Forms.Label();
            this.cbb_instrument1 = new System.Windows.Forms.ComboBox();
            this.cbb_strategy = new System.Windows.Forms.ComboBox();
            this.lbl_period = new System.Windows.Forms.Label();
            this.lbl_instrument1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_strategy_library = new System.Windows.Forms.DataGridView();
            this.strg_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strg_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strg_params = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strg_instrument_one = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strg_instrument_two = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strg_period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strg_time_start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strg_over = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strg_state = new System.Windows.Forms.DataGridViewButtonColumn();
            this.strg_program_order = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.strg_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strg_trading = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strg_test_report = new System.Windows.Forms.DataGridViewButtonColumn();
            this.strg_picture = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbx_zhuidan = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbl_zhuidan_times = new System.Windows.Forms.Label();
            this.lbl_send_again_jumps = new System.Windows.Forms.Label();
            this.lbl_cancel_wait_seconds = new System.Windows.Forms.Label();
            this.lbl_first_send_jumps = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_strategy_library)).BeginInit();
            this.gbx_zhuidan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_account_info);
            this.panel1.Controls.Add(this.btn_clear_strg_files);
            this.panel1.Controls.Add(this.btn_load_strgs_file);
            this.panel1.Controls.Add(this.cbb_strategy_file);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1202, 37);
            this.panel1.TabIndex = 0;
            // 
            // lbl_account_info
            // 
            this.lbl_account_info.AutoSize = true;
            this.lbl_account_info.Location = new System.Drawing.Point(21, 14);
            this.lbl_account_info.Name = "lbl_account_info";
            this.lbl_account_info.Size = new System.Drawing.Size(41, 12);
            this.lbl_account_info.TabIndex = 3;
            this.lbl_account_info.Text = "用户名";
            // 
            // btn_clear_strg_files
            // 
            this.btn_clear_strg_files.Location = new System.Drawing.Point(946, 11);
            this.btn_clear_strg_files.Name = "btn_clear_strg_files";
            this.btn_clear_strg_files.Size = new System.Drawing.Size(104, 23);
            this.btn_clear_strg_files.TabIndex = 2;
            this.btn_clear_strg_files.Text = "清理策略文件";
            this.btn_clear_strg_files.UseVisualStyleBackColor = true;
            // 
            // btn_load_strgs_file
            // 
            this.btn_load_strgs_file.Location = new System.Drawing.Point(795, 11);
            this.btn_load_strgs_file.Name = "btn_load_strgs_file";
            this.btn_load_strgs_file.Size = new System.Drawing.Size(99, 23);
            this.btn_load_strgs_file.TabIndex = 1;
            this.btn_load_strgs_file.Text = "加载策略文件";
            this.btn_load_strgs_file.UseVisualStyleBackColor = true;
            this.btn_load_strgs_file.Click += new System.EventHandler(this.btn_load_strgs_file_click);
            // 
            // cbb_strategy_file
            // 
            this.cbb_strategy_file.FormattingEnabled = true;
            this.cbb_strategy_file.Location = new System.Drawing.Point(331, 11);
            this.cbb_strategy_file.Name = "cbb_strategy_file";
            this.cbb_strategy_file.Size = new System.Drawing.Size(443, 20);
            this.cbb_strategy_file.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_delete_strg);
            this.groupBox1.Controls.Add(this.btn_add_strg);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dtp_over);
            this.groupBox1.Controls.Add(this.dtp_start);
            this.groupBox1.Controls.Add(this.lbl_over);
            this.groupBox1.Controls.Add(this.lbl_start);
            this.groupBox1.Controls.Add(this.cbb_interval);
            this.groupBox1.Controls.Add(this.cbb_instrument2);
            this.groupBox1.Controls.Add(this.lbl_instrument2);
            this.groupBox1.Controls.Add(this.cbb_instrument1);
            this.groupBox1.Controls.Add(this.cbb_strategy);
            this.groupBox1.Controls.Add(this.lbl_period);
            this.groupBox1.Controls.Add(this.lbl_instrument1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1202, 36);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btn_delete_strg
            // 
            this.btn_delete_strg.Location = new System.Drawing.Point(943, 9);
            this.btn_delete_strg.Name = "btn_delete_strg";
            this.btn_delete_strg.Size = new System.Drawing.Size(47, 23);
            this.btn_delete_strg.TabIndex = 15;
            this.btn_delete_strg.Text = "删除";
            this.btn_delete_strg.UseVisualStyleBackColor = true;
            // 
            // btn_add_strg
            // 
            this.btn_add_strg.Location = new System.Drawing.Point(876, 10);
            this.btn_add_strg.Name = "btn_add_strg";
            this.btn_add_strg.Size = new System.Drawing.Size(51, 23);
            this.btn_add_strg.TabIndex = 14;
            this.btn_add_strg.Text = "添加";
            this.btn_add_strg.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_run_strg);
            this.groupBox2.Controls.Add(this.rbtn_tick);
            this.groupBox2.Controls.Add(this.rbtn_K);
            this.groupBox2.Location = new System.Drawing.Point(1005, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 36);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " ";
            // 
            // btn_run_strg
            // 
            this.btn_run_strg.Location = new System.Drawing.Point(112, 9);
            this.btn_run_strg.Name = "btn_run_strg";
            this.btn_run_strg.Size = new System.Drawing.Size(55, 23);
            this.btn_run_strg.TabIndex = 2;
            this.btn_run_strg.Text = "运行";
            this.btn_run_strg.UseVisualStyleBackColor = true;
            // 
            // rbtn_tick
            // 
            this.rbtn_tick.AutoSize = true;
            this.rbtn_tick.Location = new System.Drawing.Point(63, 14);
            this.rbtn_tick.Name = "rbtn_tick";
            this.rbtn_tick.Size = new System.Drawing.Size(47, 16);
            this.rbtn_tick.TabIndex = 1;
            this.rbtn_tick.TabStop = true;
            this.rbtn_tick.Text = "Tick";
            this.rbtn_tick.UseVisualStyleBackColor = true;
            // 
            // rbtn_K
            // 
            this.rbtn_K.AutoSize = true;
            this.rbtn_K.Location = new System.Drawing.Point(16, 14);
            this.rbtn_K.Name = "rbtn_K";
            this.rbtn_K.Size = new System.Drawing.Size(41, 16);
            this.rbtn_K.TabIndex = 0;
            this.rbtn_K.TabStop = true;
            this.rbtn_K.Text = "K线";
            this.rbtn_K.UseVisualStyleBackColor = true;
            // 
            // dtp_over
            // 
            this.dtp_over.Checked = false;
            this.dtp_over.Location = new System.Drawing.Point(746, 7);
            this.dtp_over.Name = "dtp_over";
            this.dtp_over.ShowCheckBox = true;
            this.dtp_over.Size = new System.Drawing.Size(124, 21);
            this.dtp_over.TabIndex = 12;
            // 
            // dtp_start
            // 
            this.dtp_start.Location = new System.Drawing.Point(595, 6);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(110, 21);
            this.dtp_start.TabIndex = 11;
            // 
            // lbl_over
            // 
            this.lbl_over.AutoSize = true;
            this.lbl_over.Location = new System.Drawing.Point(711, 12);
            this.lbl_over.Name = "lbl_over";
            this.lbl_over.Size = new System.Drawing.Size(29, 12);
            this.lbl_over.TabIndex = 10;
            this.lbl_over.Text = "结束";
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = true;
            this.lbl_start.Location = new System.Drawing.Point(560, 12);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(29, 12);
            this.lbl_start.TabIndex = 8;
            this.lbl_start.Text = "开始";
            // 
            // cbb_interval
            // 
            this.cbb_interval.FormattingEnabled = true;
            this.cbb_interval.Location = new System.Drawing.Point(479, 8);
            this.cbb_interval.Name = "cbb_interval";
            this.cbb_interval.Size = new System.Drawing.Size(75, 20);
            this.cbb_interval.TabIndex = 7;
            // 
            // cbb_instrument2
            // 
            this.cbb_instrument2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb_instrument2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_instrument2.FormattingEnabled = true;
            this.cbb_instrument2.Location = new System.Drawing.Point(340, 9);
            this.cbb_instrument2.Name = "cbb_instrument2";
            this.cbb_instrument2.Size = new System.Drawing.Size(98, 20);
            this.cbb_instrument2.TabIndex = 6;
            // 
            // lbl_instrument2
            // 
            this.lbl_instrument2.AutoSize = true;
            this.lbl_instrument2.Location = new System.Drawing.Point(299, 12);
            this.lbl_instrument2.Name = "lbl_instrument2";
            this.lbl_instrument2.Size = new System.Drawing.Size(35, 12);
            this.lbl_instrument2.TabIndex = 5;
            this.lbl_instrument2.Text = "合约2";
            // 
            // cbb_instrument1
            // 
            this.cbb_instrument1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb_instrument1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_instrument1.FormattingEnabled = true;
            this.cbb_instrument1.Location = new System.Drawing.Point(197, 9);
            this.cbb_instrument1.Name = "cbb_instrument1";
            this.cbb_instrument1.Size = new System.Drawing.Size(96, 20);
            this.cbb_instrument1.TabIndex = 4;
            // 
            // cbb_strategy
            // 
            this.cbb_strategy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb_strategy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_strategy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_strategy.Location = new System.Drawing.Point(42, 10);
            this.cbb_strategy.Name = "cbb_strategy";
            this.cbb_strategy.Size = new System.Drawing.Size(108, 20);
            this.cbb_strategy.TabIndex = 3;
            // 
            // lbl_period
            // 
            this.lbl_period.AutoSize = true;
            this.lbl_period.Location = new System.Drawing.Point(444, 12);
            this.lbl_period.Name = "lbl_period";
            this.lbl_period.Size = new System.Drawing.Size(29, 12);
            this.lbl_period.TabIndex = 2;
            this.lbl_period.Text = "周期";
            // 
            // lbl_instrument1
            // 
            this.lbl_instrument1.AutoSize = true;
            this.lbl_instrument1.Location = new System.Drawing.Point(156, 13);
            this.lbl_instrument1.Name = "lbl_instrument1";
            this.lbl_instrument1.Size = new System.Drawing.Size(35, 12);
            this.lbl_instrument1.TabIndex = 1;
            this.lbl_instrument1.Text = "合约1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "策略";
            // 
            // dgv_strategy_library
            // 
            this.dgv_strategy_library.AllowUserToAddRows = false;
            this.dgv_strategy_library.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_strategy_library.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.strg_name,
            this.strg_type,
            this.strg_params,
            this.strg_instrument_one,
            this.strg_instrument_two,
            this.strg_period,
            this.strg_time_start,
            this.strg_over,
            this.strg_state,
            this.strg_program_order,
            this.strg_time,
            this.strg_trading,
            this.strg_test_report,
            this.strg_picture});
            this.dgv_strategy_library.Location = new System.Drawing.Point(0, 81);
            this.dgv_strategy_library.Name = "dgv_strategy_library";
            this.dgv_strategy_library.RowHeadersVisible = false;
            this.dgv_strategy_library.RowHeadersWidth = 20;
            this.dgv_strategy_library.RowTemplate.Height = 23;
            this.dgv_strategy_library.Size = new System.Drawing.Size(1202, 429);
            this.dgv_strategy_library.TabIndex = 2;
            // 
            // strg_name
            // 
            this.strg_name.HeaderText = "编号";
            this.strg_name.Name = "strg_name";
            this.strg_name.ReadOnly = true;
            this.strg_name.Width = 60;
            // 
            // strg_type
            // 
            this.strg_type.HeaderText = "类型";
            this.strg_type.Name = "strg_type";
            this.strg_type.ReadOnly = true;
            this.strg_type.Width = 60;
            // 
            // strg_params
            // 
            this.strg_params.HeaderText = "参数";
            this.strg_params.Name = "strg_params";
            this.strg_params.ReadOnly = true;
            // 
            // strg_instrument_one
            // 
            this.strg_instrument_one.HeaderText = "合约1";
            this.strg_instrument_one.Name = "strg_instrument_one";
            this.strg_instrument_one.ReadOnly = true;
            this.strg_instrument_one.Width = 60;
            // 
            // strg_instrument_two
            // 
            this.strg_instrument_two.HeaderText = "合约2";
            this.strg_instrument_two.Name = "strg_instrument_two";
            this.strg_instrument_two.ReadOnly = true;
            this.strg_instrument_two.Width = 60;
            // 
            // strg_period
            // 
            this.strg_period.HeaderText = "周期";
            this.strg_period.Name = "strg_period";
            this.strg_period.ReadOnly = true;
            this.strg_period.Width = 60;
            // 
            // strg_time_start
            // 
            this.strg_time_start.HeaderText = "开始时间";
            this.strg_time_start.Name = "strg_time_start";
            this.strg_time_start.ReadOnly = true;
            // 
            // strg_over
            // 
            this.strg_over.HeaderText = "结束时间";
            this.strg_over.Name = "strg_over";
            this.strg_over.ReadOnly = true;
            // 
            // strg_state
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "未加载";
            this.strg_state.DefaultCellStyle = dataGridViewCellStyle2;
            this.strg_state.HeaderText = "状态";
            this.strg_state.Name = "strg_state";
            this.strg_state.ReadOnly = true;
            this.strg_state.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // strg_program_order
            // 
            this.strg_program_order.HeaderText = "程序化下单";
            this.strg_program_order.Name = "strg_program_order";
            // 
            // strg_time
            // 
            this.strg_time.HeaderText = "时间";
            this.strg_time.Name = "strg_time";
            this.strg_time.ReadOnly = true;
            // 
            // strg_trading
            // 
            this.strg_trading.HeaderText = "交易";
            this.strg_trading.Name = "strg_trading";
            this.strg_trading.ReadOnly = true;
            // 
            // strg_test_report
            // 
            this.strg_test_report.HeaderText = "测试报告";
            this.strg_test_report.Name = "strg_test_report";
            this.strg_test_report.ReadOnly = true;
            // 
            // strg_picture
            // 
            this.strg_picture.HeaderText = "图形显示";
            this.strg_picture.Name = "strg_picture";
            this.strg_picture.ReadOnly = true;
            // 
            // gbx_zhuidan
            // 
            this.gbx_zhuidan.Controls.Add(this.pictureBox1);
            this.gbx_zhuidan.Controls.Add(this.numericUpDown4);
            this.gbx_zhuidan.Controls.Add(this.numericUpDown3);
            this.gbx_zhuidan.Controls.Add(this.numericUpDown2);
            this.gbx_zhuidan.Controls.Add(this.numericUpDown1);
            this.gbx_zhuidan.Controls.Add(this.lbl_zhuidan_times);
            this.gbx_zhuidan.Controls.Add(this.lbl_send_again_jumps);
            this.gbx_zhuidan.Controls.Add(this.lbl_cancel_wait_seconds);
            this.gbx_zhuidan.Controls.Add(this.lbl_first_send_jumps);
            this.gbx_zhuidan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbx_zhuidan.Location = new System.Drawing.Point(0, 512);
            this.gbx_zhuidan.Name = "gbx_zhuidan";
            this.gbx_zhuidan.Size = new System.Drawing.Size(1202, 35);
            this.gbx_zhuidan.TabIndex = 3;
            this.gbx_zhuidan.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1162, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 19);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(503, 10);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(34, 21);
            this.numericUpDown4.TabIndex = 7;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(382, 8);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(34, 21);
            this.numericUpDown3.TabIndex = 6;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(239, 10);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(34, 21);
            this.numericUpDown2.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(104, 10);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(34, 21);
            this.numericUpDown1.TabIndex = 4;
            // 
            // lbl_zhuidan_times
            // 
            this.lbl_zhuidan_times.AutoSize = true;
            this.lbl_zhuidan_times.Location = new System.Drawing.Point(444, 16);
            this.lbl_zhuidan_times.Name = "lbl_zhuidan_times";
            this.lbl_zhuidan_times.Size = new System.Drawing.Size(53, 12);
            this.lbl_zhuidan_times.TabIndex = 3;
            this.lbl_zhuidan_times.Text = "追单次数";
            // 
            // lbl_send_again_jumps
            // 
            this.lbl_send_again_jumps.AutoSize = true;
            this.lbl_send_again_jumps.Location = new System.Drawing.Point(299, 17);
            this.lbl_send_again_jumps.Name = "lbl_send_again_jumps";
            this.lbl_send_again_jumps.Size = new System.Drawing.Size(77, 12);
            this.lbl_send_again_jumps.TabIndex = 2;
            this.lbl_send_again_jumps.Text = "再发偏移跳数";
            // 
            // lbl_cancel_wait_seconds
            // 
            this.lbl_cancel_wait_seconds.AutoSize = true;
            this.lbl_cancel_wait_seconds.Location = new System.Drawing.Point(156, 17);
            this.lbl_cancel_wait_seconds.Name = "lbl_cancel_wait_seconds";
            this.lbl_cancel_wait_seconds.Size = new System.Drawing.Size(77, 12);
            this.lbl_cancel_wait_seconds.TabIndex = 1;
            this.lbl_cancel_wait_seconds.Text = "撤单等待秒数";
            // 
            // lbl_first_send_jumps
            // 
            this.lbl_first_send_jumps.AutoSize = true;
            this.lbl_first_send_jumps.Location = new System.Drawing.Point(21, 16);
            this.lbl_first_send_jumps.Name = "lbl_first_send_jumps";
            this.lbl_first_send_jumps.Size = new System.Drawing.Size(77, 12);
            this.lbl_first_send_jumps.TabIndex = 0;
            this.lbl_first_send_jumps.Text = "首发偏移跳数";
            // 
            // Plat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbx_zhuidan);
            this.Controls.Add(this.dgv_strategy_library);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Plat";
            this.Size = new System.Drawing.Size(1202, 547);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_strategy_library)).EndInit();
            this.gbx_zhuidan.ResumeLayout(false);
            this.gbx_zhuidan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_account_info;
        private System.Windows.Forms.Button btn_clear_strg_files;
        private System.Windows.Forms.Button btn_load_strgs_file;
        private System.Windows.Forms.ComboBox cbb_strategy_file;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_delete_strg;
        private System.Windows.Forms.Button btn_add_strg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_run_strg;
        private System.Windows.Forms.RadioButton rbtn_tick;
        private System.Windows.Forms.RadioButton rbtn_K;
        private System.Windows.Forms.DateTimePicker dtp_over;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.Label lbl_over;
        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.ComboBox cbb_interval;
        private System.Windows.Forms.ComboBox cbb_instrument2;
        private System.Windows.Forms.Label lbl_instrument2;
        private System.Windows.Forms.ComboBox cbb_instrument1;
        private System.Windows.Forms.ComboBox cbb_strategy;
        private System.Windows.Forms.Label lbl_period;
        private System.Windows.Forms.Label lbl_instrument1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_strategy_library;
        private System.Windows.Forms.DataGridViewTextBoxColumn strg_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn strg_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn strg_params;
        private System.Windows.Forms.DataGridViewTextBoxColumn strg_instrument_one;
        private System.Windows.Forms.DataGridViewTextBoxColumn strg_instrument_two;
        private System.Windows.Forms.DataGridViewTextBoxColumn strg_period;
        private System.Windows.Forms.DataGridViewTextBoxColumn strg_time_start;
        private System.Windows.Forms.DataGridViewTextBoxColumn strg_over;
        private System.Windows.Forms.DataGridViewButtonColumn strg_state;
        private System.Windows.Forms.DataGridViewCheckBoxColumn strg_program_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn strg_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn strg_trading;
        private System.Windows.Forms.DataGridViewButtonColumn strg_test_report;
        private System.Windows.Forms.DataGridViewButtonColumn strg_picture;
        private System.Windows.Forms.GroupBox gbx_zhuidan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lbl_zhuidan_times;
        private System.Windows.Forms.Label lbl_send_again_jumps;
        private System.Windows.Forms.Label lbl_cancel_wait_seconds;
        private System.Windows.Forms.Label lbl_first_send_jumps;
    }
}
