using EasyRest.UI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EasyRest
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private bool _IsClosedByXButton = true;

        private void UpdateStartStopCheckBox()
        {
            Color ColorToSet =
                ChkStartStop.Checked ?
                Color.FromArgb(0, 192, 0) :
                Color.FromArgb(192, 0, 0);

            ChkStartStop.BackColor = ColorToSet;
            ChkStartStop.FlatAppearance.MouseDownBackColor = ColorToSet;
            ChkStartStop.FlatAppearance.MouseOverBackColor = ColorToSet;

            ChkStartStop.Text =
                ChkStartStop.Checked ?
                "يعمل" : "متوقف";

        }

        private void ChkStartStop_CheckedChanged(object sender, EventArgs e)
        {
            UpdateStartStopCheckBox();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            UpdateStartStopCheckBox();
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            FrmAbout frmAbout = new FrmAbout();

            frmAbout.ShowDialog();

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            _IsClosedByXButton = false;
            Application.Exit();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_IsClosedByXButton)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void NiEasyRest_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            FrmAlarmOverlay frmAlarm = new FrmAlarmOverlay("Testing", 10);

            frmAlarm.Show();

        }
    }
}
