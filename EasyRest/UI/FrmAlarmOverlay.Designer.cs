namespace EasyRest.UI
{
    partial class FrmAlarmOverlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlarmOverlay));
            this.LbAlarmMessage = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.TShowTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LbAlarmMessage
            // 
            this.LbAlarmMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbAlarmMessage.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Bold);
            this.LbAlarmMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbAlarmMessage.Location = new System.Drawing.Point(12, 95);
            this.LbAlarmMessage.Name = "LbAlarmMessage";
            this.LbAlarmMessage.Size = new System.Drawing.Size(760, 103);
            this.LbAlarmMessage.TabIndex = 0;
            this.LbAlarmMessage.Text = "N/A";
            this.LbAlarmMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(300, 300);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(184, 65);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Text = "إغلاق";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // TShowTimer
            // 
            this.TShowTimer.Tick += new System.EventHandler(this.TShowTimer_Tick);
            // 
            // FrmAlarmOverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.ControlBox = false;
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LbAlarmMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAlarmOverlay";
            this.Opacity = 0.95D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.Text = "تنبيه";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAlarmOverlay_FormClosed);
            this.Load += new System.EventHandler(this.FrmAlarmOverlay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LbAlarmMessage;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Timer TShowTimer;
    }
}