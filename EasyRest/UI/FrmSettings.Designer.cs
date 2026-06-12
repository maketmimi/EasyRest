namespace EasyRest.UI
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LbCurrentPeriod = new System.Windows.Forms.Label();
            this.CbCurrentPeriod = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NudWorkDuration = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NudRestDuration = new System.Windows.Forms.NumericUpDown();
            this.BtnApply = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CbWorkPeriodAlarmType = new System.Windows.Forms.ComboBox();
            this.CbRestPeriodAlarmType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudWorkDuration)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudRestDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LbCurrentPeriod);
            this.groupBox2.Controls.Add(this.CbCurrentPeriod);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 129);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تغيير الفترة الحالية";
            // 
            // LbCurrentPeriod
            // 
            this.LbCurrentPeriod.AutoSize = true;
            this.LbCurrentPeriod.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCurrentPeriod.ForeColor = System.Drawing.Color.Black;
            this.LbCurrentPeriod.Location = new System.Drawing.Point(329, 55);
            this.LbCurrentPeriod.Name = "LbCurrentPeriod";
            this.LbCurrentPeriod.Size = new System.Drawing.Size(135, 37);
            this.LbCurrentPeriod.TabIndex = 1;
            this.LbCurrentPeriod.Text = "اختر الفترة:";
            this.LbCurrentPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbWorkPeriodAlarmType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.NudWorkDuration);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "إعدادات فترة العمل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(260, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "دقيقة";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(426, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "مدة الفترة:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CbRestPeriodAlarmType);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.NudRestDuration);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox3.Location = new System.Drawing.Point(12, 275);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(568, 122);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "إعدادات فترة الراحة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(260, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "دقيقة";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(426, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "مدة الفترة:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // BtnApply
            // 
            this.BtnApply.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApply.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnApply.Location = new System.Drawing.Point(12, 416);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(141, 49);
            this.BtnApply.TabIndex = 5;
            this.BtnApply.Text = "تطبيق";
            this.BtnApply.UseVisualStyleBackColor = true;
            this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnCancel.Location = new System.Drawing.Point(159, 416);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(141, 49);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "إلغاء";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(131, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "نوع التنبيه:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.CbWorkPeriodAlarmType.TabIndex = 2;
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
            this.CbRestPeriodAlarmType.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(131, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "نوع التنبيه:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(592, 474);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnApply);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الإعدادت";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudWorkDuration)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudRestDuration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CbCurrentPeriod;
        private System.Windows.Forms.Label LbCurrentPeriod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NudWorkDuration;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NudRestDuration;
        private System.Windows.Forms.Button BtnApply;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbWorkPeriodAlarmType;
        private System.Windows.Forms.ComboBox CbRestPeriodAlarmType;
        private System.Windows.Forms.Label label6;
    }
}