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
            this.ChkStartStop = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LbCountDown = new System.Windows.Forms.Label();
            this.LbCurrentPeriod = new System.Windows.Forms.Label();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.NiEasyRest = new System.Windows.Forms.NotifyIcon(this.components);
            this.TMainTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.ChkStartStop.CheckedChanged += new System.EventHandler(this.ChkStartStop_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChkStartStop);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(21, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 158);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "حالة البرنامج";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LbCountDown);
            this.groupBox2.Controls.Add(this.LbCurrentPeriod);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(21, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 176);
            this.groupBox2.TabIndex = 2;
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
            // BtnSettings
            // 
            this.BtnSettings.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnSettings.Location = new System.Drawing.Point(36, 390);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(141, 49);
            this.BtnSettings.TabIndex = 1;
            this.BtnSettings.Text = "الإعدادات";
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // BtnAbout
            // 
            this.BtnAbout.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbout.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnAbout.Location = new System.Drawing.Point(191, 390);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(141, 49);
            this.BtnAbout.TabIndex = 2;
            this.BtnAbout.Text = "عن البرنامج";
            this.BtnAbout.UseVisualStyleBackColor = true;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
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
            this.BtnClose.Location = new System.Drawing.Point(346, 390);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(141, 49);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "إغلاق التطبيق";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // NiEasyRest
            // 
            this.NiEasyRest.Icon = ((System.Drawing.Icon)(resources.GetObject("NiEasyRest.Icon")));
            this.NiEasyRest.Visible = true;
            this.NiEasyRest.Click += new System.EventHandler(this.NiEasyRest_Click);
            // 
            // TMainTimer
            // 
            this.TMainTimer.Interval = 1000;
            this.TMainTimer.Tick += new System.EventHandler(this.TMainTimer_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(523, 454);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnAbout);
            this.Controls.Add(this.BtnSettings);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox ChkStartStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LbCountDown;
        private System.Windows.Forms.Label LbCurrentPeriod;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.NotifyIcon NiEasyRest;
        private System.Windows.Forms.Timer TMainTimer;
    }
}

