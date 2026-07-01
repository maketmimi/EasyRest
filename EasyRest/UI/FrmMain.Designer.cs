namespace EasyRest
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.NiEasyRest = new System.Windows.Forms.NotifyIcon(this.components);
            this.TMainTimer = new System.Windows.Forms.Timer(this.components);
            this.TabMain = new System.Windows.Forms.TabControl();
            this.PbMain = new System.Windows.Forms.TabPage();
            this.BtnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LbCountDown = new System.Windows.Forms.Label();
            this.LbCurrentPeriod = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChkStartStop = new System.Windows.Forms.CheckBox();
            this.PgSettings = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.TxtSoundFileName = new System.Windows.Forms.TextBox();
            this.BtnApply = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CbRestPeriodAlarmType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NudRestDuration = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CbWorkPeriodAlarmType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.NudWorkDuration = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CbCurrentPeriod = new System.Windows.Forms.ComboBox();
            this.PbAbout = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PbAppLogo = new System.Windows.Forms.PictureBox();
            this.LLbGithubLink = new System.Windows.Forms.LinkLabel();
            this.ImgMain = new System.Windows.Forms.ImageList(this.components);
            this.BtnBrowseAlarmSound = new System.Windows.Forms.Button();
            this.CbPeriodToSetSoundFor = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.BtnSetDefaultAlarmSound = new System.Windows.Forms.Button();
            this.OpenFALarmSound = new System.Windows.Forms.OpenFileDialog();
            this.TabMain.SuspendLayout();
            this.PbMain.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PgSettings.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudRestDuration)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudWorkDuration)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.PbAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAppLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // NiEasyRest
            // 
            this.NiEasyRest.Icon = ((System.Drawing.Icon)(resources.GetObject("NiEasyRest.Icon")));
            this.NiEasyRest.Text = "برنامج منظم فترات الراحة";
            this.NiEasyRest.Visible = true;
            this.NiEasyRest.Click += new System.EventHandler(this.NiEasyRest_Click);
            // 
            // TMainTimer
            // 
            this.TMainTimer.Interval = 1000;
            this.TMainTimer.Tick += new System.EventHandler(this.TMainTimer_Tick);
            // 
            // TabMain
            // 
            this.TabMain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.TabMain.Controls.Add(this.PbMain);
            this.TabMain.Controls.Add(this.PgSettings);
            this.TabMain.Controls.Add(this.PbAbout);
            this.TabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabMain.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabMain.HotTrack = true;
            this.TabMain.ImageList = this.ImgMain;
            this.TabMain.Location = new System.Drawing.Point(0, 0);
            this.TabMain.Name = "TabMain";
            this.TabMain.RightToLeftLayout = true;
            this.TabMain.SelectedIndex = 0;
            this.TabMain.ShowToolTips = true;
            this.TabMain.Size = new System.Drawing.Size(645, 513);
            this.TabMain.TabIndex = 0;
            this.TabMain.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TabMain_Selecting);
            // 
            // PbMain
            // 
            this.PbMain.Controls.Add(this.BtnClose);
            this.PbMain.Controls.Add(this.groupBox2);
            this.PbMain.Controls.Add(this.groupBox1);
            this.PbMain.ImageIndex = 0;
            this.PbMain.Location = new System.Drawing.Point(4, 4);
            this.PbMain.Name = "PbMain";
            this.PbMain.Padding = new System.Windows.Forms.Padding(3);
            this.PbMain.Size = new System.Drawing.Size(637, 475);
            this.PbMain.TabIndex = 0;
            this.PbMain.Text = "الرئيسية";
            this.PbMain.ToolTipText = "الصفحة الرئيسية";
            this.PbMain.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(248, 400);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(141, 49);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "إغلاق التطبيق";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LbCountDown);
            this.groupBox2.Controls.Add(this.LbCurrentPeriod);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(78, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 176);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الفترة الحالية";
            // 
            // LbCountDown
            // 
            this.LbCountDown.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCountDown.ForeColor = System.Drawing.Color.Maroon;
            this.LbCountDown.Location = new System.Drawing.Point(33, 63);
            this.LbCountDown.Name = "LbCountDown";
            this.LbCountDown.Size = new System.Drawing.Size(195, 71);
            this.LbCountDown.TabIndex = 1;
            this.LbCountDown.Text = "N/A";
            this.LbCountDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbCurrentPeriod
            // 
            this.LbCurrentPeriod.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCurrentPeriod.Location = new System.Drawing.Point(234, 63);
            this.LbCurrentPeriod.Name = "LbCurrentPeriod";
            this.LbCurrentPeriod.Size = new System.Drawing.Size(213, 71);
            this.LbCurrentPeriod.TabIndex = 0;
            this.LbCurrentPeriod.Text = "N/A";
            this.LbCurrentPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChkStartStop);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(78, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "حالة البرنامج";
            // 
            // ChkStartStop
            // 
            this.ChkStartStop.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkStartStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ChkStartStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkStartStop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ChkStartStop.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ChkStartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChkStartStop.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkStartStop.ForeColor = System.Drawing.Color.White;
            this.ChkStartStop.Location = new System.Drawing.Point(112, 49);
            this.ChkStartStop.Name = "ChkStartStop";
            this.ChkStartStop.Size = new System.Drawing.Size(257, 83);
            this.ChkStartStop.TabIndex = 0;
            this.ChkStartStop.Text = "متوقف";
            this.ChkStartStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChkStartStop.UseVisualStyleBackColor = false;
            this.ChkStartStop.Click += new System.EventHandler(this.ChkStartStop_CheckedChanged);
            // 
            // PgSettings
            // 
            this.PgSettings.AutoScroll = true;
            this.PgSettings.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.PgSettings.Controls.Add(this.groupBox6);
            this.PgSettings.Controls.Add(this.BtnApply);
            this.PgSettings.Controls.Add(this.groupBox3);
            this.PgSettings.Controls.Add(this.groupBox4);
            this.PgSettings.Controls.Add(this.groupBox5);
            this.PgSettings.ImageIndex = 1;
            this.PgSettings.Location = new System.Drawing.Point(4, 4);
            this.PgSettings.Name = "PgSettings";
            this.PgSettings.Padding = new System.Windows.Forms.Padding(3);
            this.PgSettings.Size = new System.Drawing.Size(637, 475);
            this.PgSettings.TabIndex = 1;
            this.PgSettings.Text = "الإعدادات";
            this.PgSettings.ToolTipText = "قم بتعديل الفواصل الزمنية وأنواع التنبيهات";
            this.PgSettings.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.BtnSetDefaultAlarmSound);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.CbPeriodToSetSoundFor);
            this.groupBox6.Controls.Add(this.BtnBrowseAlarmSound);
            this.groupBox6.Controls.Add(this.TxtSoundFileName);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox6.Location = new System.Drawing.Point(26, 459);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(568, 204);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "إعدادات صوت التنبيه";
            // 
            // TxtSoundFileName
            // 
            this.TxtSoundFileName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSoundFileName.Location = new System.Drawing.Point(260, 116);
            this.TxtSoundFileName.Name = "TxtSoundFileName";
            this.TxtSoundFileName.ReadOnly = true;
            this.TxtSoundFileName.Size = new System.Drawing.Size(295, 35);
            this.TxtSoundFileName.TabIndex = 4;
            // 
            // BtnApply
            // 
            this.BtnApply.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApply.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.BtnApply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnApply.Location = new System.Drawing.Point(495, 402);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(99, 43);
            this.BtnApply.TabIndex = 3;
            this.BtnApply.Text = "تطبيق";
            this.BtnApply.UseVisualStyleBackColor = true;
            this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CbRestPeriodAlarmType);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.NudRestDuration);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox3.Location = new System.Drawing.Point(26, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(568, 122);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "إعدادات فترة الراحة";
            // 
            // CbRestPeriodAlarmType
            // 
            this.CbRestPeriodAlarmType.BackColor = System.Drawing.Color.White;
            this.CbRestPeriodAlarmType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbRestPeriodAlarmType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbRestPeriodAlarmType.ForeColor = System.Drawing.Color.Black;
            this.CbRestPeriodAlarmType.FormattingEnabled = true;
            this.CbRestPeriodAlarmType.Items.AddRange(new object[] {
            "تنبيه ملء الشاشة",
            "تنبيه صوتي",
            "تنبيه بالإشعارات"});
            this.CbRestPeriodAlarmType.Location = new System.Drawing.Point(31, 62);
            this.CbRestPeriodAlarmType.Name = "CbRestPeriodAlarmType";
            this.CbRestPeriodAlarmType.Size = new System.Drawing.Size(189, 29);
            this.CbRestPeriodAlarmType.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(260, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 37);
            this.label6.TabIndex = 3;
            this.label6.Text = "دقيقة";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(131, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "نوع التنبيه:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(426, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 37);
            this.label8.TabIndex = 2;
            this.label8.Text = "مدة الفترة:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NudRestDuration
            // 
            this.NudRestDuration.BackColor = System.Drawing.Color.White;
            this.NudRestDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NudRestDuration.ForeColor = System.Drawing.Color.Black;
            this.NudRestDuration.Location = new System.Drawing.Point(348, 56);
            this.NudRestDuration.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.NudRestDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudRestDuration.Name = "NudRestDuration";
            this.NudRestDuration.Size = new System.Drawing.Size(72, 35);
            this.NudRestDuration.TabIndex = 0;
            this.NudRestDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudRestDuration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CbWorkPeriodAlarmType);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.NudWorkDuration);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox4.Location = new System.Drawing.Point(26, 146);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(568, 122);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "إعدادات فترة العمل";
            // 
            // CbWorkPeriodAlarmType
            // 
            this.CbWorkPeriodAlarmType.BackColor = System.Drawing.Color.White;
            this.CbWorkPeriodAlarmType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbWorkPeriodAlarmType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbWorkPeriodAlarmType.ForeColor = System.Drawing.Color.Black;
            this.CbWorkPeriodAlarmType.FormattingEnabled = true;
            this.CbWorkPeriodAlarmType.Items.AddRange(new object[] {
            "تنبيه ملء الشاشة",
            "تنبيه صوتي",
            "تنبيه بالإشعارات"});
            this.CbWorkPeriodAlarmType.Location = new System.Drawing.Point(31, 62);
            this.CbWorkPeriodAlarmType.Name = "CbWorkPeriodAlarmType";
            this.CbWorkPeriodAlarmType.Size = new System.Drawing.Size(189, 29);
            this.CbWorkPeriodAlarmType.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(131, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "نوع التنبيه:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(260, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 37);
            this.label10.TabIndex = 3;
            this.label10.Text = "دقيقة";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(426, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 37);
            this.label11.TabIndex = 2;
            this.label11.Text = "مدة الفترة:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NudWorkDuration
            // 
            this.NudWorkDuration.BackColor = System.Drawing.Color.White;
            this.NudWorkDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NudWorkDuration.ForeColor = System.Drawing.Color.Black;
            this.NudWorkDuration.Location = new System.Drawing.Point(348, 56);
            this.NudWorkDuration.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.NudWorkDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudWorkDuration.Name = "NudWorkDuration";
            this.NudWorkDuration.Size = new System.Drawing.Size(72, 35);
            this.NudWorkDuration.TabIndex = 0;
            this.NudWorkDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudWorkDuration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.CbCurrentPeriod);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox5.Location = new System.Drawing.Point(26, 11);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(568, 129);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "تغيير الفترة الحالية";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(329, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 37);
            this.label12.TabIndex = 1;
            this.label12.Text = "اختر الفترة:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CbCurrentPeriod
            // 
            this.CbCurrentPeriod.BackColor = System.Drawing.Color.White;
            this.CbCurrentPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCurrentPeriod.ForeColor = System.Drawing.Color.Black;
            this.CbCurrentPeriod.FormattingEnabled = true;
            this.CbCurrentPeriod.Location = new System.Drawing.Point(105, 58);
            this.CbCurrentPeriod.Name = "CbCurrentPeriod";
            this.CbCurrentPeriod.Size = new System.Drawing.Size(218, 38);
            this.CbCurrentPeriod.TabIndex = 0;
            // 
            // PbAbout
            // 
            this.PbAbout.Controls.Add(this.pictureBox2);
            this.PbAbout.Controls.Add(this.label5);
            this.PbAbout.Controls.Add(this.label4);
            this.PbAbout.Controls.Add(this.label3);
            this.PbAbout.Controls.Add(this.label2);
            this.PbAbout.Controls.Add(this.label1);
            this.PbAbout.Controls.Add(this.PbAppLogo);
            this.PbAbout.Controls.Add(this.LLbGithubLink);
            this.PbAbout.ImageIndex = 2;
            this.PbAbout.Location = new System.Drawing.Point(4, 4);
            this.PbAbout.Name = "PbAbout";
            this.PbAbout.Padding = new System.Windows.Forms.Padding(3);
            this.PbAbout.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PbAbout.Size = new System.Drawing.Size(637, 475);
            this.PbAbout.TabIndex = 2;
            this.PbAbout.Text = "عن البرنامج";
            this.PbAbout.ToolTipText = "حول التطبيق";
            this.PbAbout.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(64, 376);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(251, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(361, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "تم تطوير هذا التطبيق بواسطة مالك التميمي.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(494, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "الإصدار 1.0.0";
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(116, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(496, 79);
            this.label3.TabIndex = 11;
            this.label3.Text = "منظم فترات راحة بسيط يساعدك على تحقيق توازن أفضل بين العمل والراحة.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(327, 101);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(249, 67);
            this.label2.TabIndex = 10;
            this.label2.Text = "Easy Rest";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(307, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 71);
            this.label1.TabIndex = 9;
            this.label1.Text = "منظم الراحة";
            // 
            // PbAppLogo
            // 
            this.PbAppLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbAppLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbAppLogo.Image")));
            this.PbAppLogo.Location = new System.Drawing.Point(34, 11);
            this.PbAppLogo.Name = "PbAppLogo";
            this.PbAppLogo.Size = new System.Drawing.Size(214, 171);
            this.PbAppLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbAppLogo.TabIndex = 8;
            this.PbAppLogo.TabStop = false;
            this.PbAppLogo.Click += new System.EventHandler(this.PbAppLogo_Click);
            // 
            // LLbGithubLink
            // 
            this.LLbGithubLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LLbGithubLink.AutoSize = true;
            this.LLbGithubLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LLbGithubLink.DisabledLinkColor = System.Drawing.Color.Black;
            this.LLbGithubLink.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLbGithubLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LLbGithubLink.LinkColor = System.Drawing.Color.Black;
            this.LLbGithubLink.Location = new System.Drawing.Point(6, 447);
            this.LLbGithubLink.Name = "LLbGithubLink";
            this.LLbGithubLink.Size = new System.Drawing.Size(221, 25);
            this.LLbGithubLink.TabIndex = 15;
            this.LLbGithubLink.TabStop = true;
            this.LLbGithubLink.Text = "Malek Altamimi © 2026";
            this.LLbGithubLink.VisitedLinkColor = System.Drawing.Color.Black;
            this.LLbGithubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLbGithubLink_LinkClicked);
            // 
            // ImgMain
            // 
            this.ImgMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgMain.ImageStream")));
            this.ImgMain.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgMain.Images.SetKeyName(0, "home.png");
            this.ImgMain.Images.SetKeyName(1, "setting.png");
            this.ImgMain.Images.SetKeyName(2, "about.png");
            // 
            // BtnBrowseAlarmSound
            // 
            this.BtnBrowseAlarmSound.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBrowseAlarmSound.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnBrowseAlarmSound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnBrowseAlarmSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBrowseAlarmSound.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBrowseAlarmSound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnBrowseAlarmSound.Location = new System.Drawing.Point(155, 116);
            this.BtnBrowseAlarmSound.Name = "BtnBrowseAlarmSound";
            this.BtnBrowseAlarmSound.Size = new System.Drawing.Size(99, 34);
            this.BtnBrowseAlarmSound.TabIndex = 4;
            this.BtnBrowseAlarmSound.Text = "اختيار صوت";
            this.BtnBrowseAlarmSound.UseVisualStyleBackColor = true;
            this.BtnBrowseAlarmSound.Click += new System.EventHandler(this.BtnBrowseAlarmSound_Click);
            // 
            // CbPeriodToSetSoundFor
            // 
            this.CbPeriodToSetSoundFor.BackColor = System.Drawing.Color.White;
            this.CbPeriodToSetSoundFor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbPeriodToSetSoundFor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbPeriodToSetSoundFor.ForeColor = System.Drawing.Color.Black;
            this.CbPeriodToSetSoundFor.FormattingEnabled = true;
            this.CbPeriodToSetSoundFor.Location = new System.Drawing.Point(306, 43);
            this.CbPeriodToSetSoundFor.Name = "CbPeriodToSetSoundFor";
            this.CbPeriodToSetSoundFor.Size = new System.Drawing.Size(189, 29);
            this.CbPeriodToSetSoundFor.TabIndex = 6;
            this.CbPeriodToSetSoundFor.SelectedIndexChanged += new System.EventHandler(this.CbPeriodToSetSoundFor_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(501, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 25);
            this.label13.TabIndex = 6;
            this.label13.Text = "الفترة:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(433, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 25);
            this.label14.TabIndex = 7;
            this.label14.Text = "الصوت الحالي:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSetDefaultAlarmSound
            // 
            this.BtnSetDefaultAlarmSound.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnSetDefaultAlarmSound.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnSetDefaultAlarmSound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnSetDefaultAlarmSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSetDefaultAlarmSound.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSetDefaultAlarmSound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnSetDefaultAlarmSound.Location = new System.Drawing.Point(411, 157);
            this.BtnSetDefaultAlarmSound.Name = "BtnSetDefaultAlarmSound";
            this.BtnSetDefaultAlarmSound.Size = new System.Drawing.Size(144, 34);
            this.BtnSetDefaultAlarmSound.TabIndex = 8;
            this.BtnSetDefaultAlarmSound.Text = "الصوت الإفتراضي";
            this.BtnSetDefaultAlarmSound.UseVisualStyleBackColor = true;
            this.BtnSetDefaultAlarmSound.Click += new System.EventHandler(this.BtnSetDefaultAlarmSound_Click);
            // 
            // OpenFALarmSound
            // 
            this.OpenFALarmSound.Filter = "Wave Files|*.wav;*.wave";
            this.OpenFALarmSound.Title = "اختيار صوت التنبيه";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 513);
            this.Controls.Add(this.TabMain);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "منظم الراحة";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.TabMain.ResumeLayout(false);
            this.PbMain.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.PgSettings.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudRestDuration)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudWorkDuration)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.PbAbout.ResumeLayout(false);
            this.PbAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAppLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon NiEasyRest;
        private System.Windows.Forms.Timer TMainTimer;
        private System.Windows.Forms.TabControl TabMain;
        private System.Windows.Forms.TabPage PbMain;
        private System.Windows.Forms.TabPage PgSettings;
        private System.Windows.Forms.TabPage PbAbout;
        private System.Windows.Forms.ImageList ImgMain;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LbCountDown;
        private System.Windows.Forms.Label LbCurrentPeriod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ChkStartStop;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PbAppLogo;
        private System.Windows.Forms.LinkLabel LLbGithubLink;
        private System.Windows.Forms.Button BtnApply;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox CbRestPeriodAlarmType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown NudRestDuration;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox CbWorkPeriodAlarmType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown NudWorkDuration;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CbCurrentPeriod;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox TxtSoundFileName;
        private System.Windows.Forms.Button BtnBrowseAlarmSound;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CbPeriodToSetSoundFor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button BtnSetDefaultAlarmSound;
        private System.Windows.Forms.OpenFileDialog OpenFALarmSound;
    }
}

