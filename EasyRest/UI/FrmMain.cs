using EasyRest.Core;
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
        private EasyRestStatus _Status = new EasyRestStatus(); 

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

        private void SetRunningState(bool IsRunning)
        {
            if (IsRunning)
            {
                _Status.Start();
                TMainTimer.Start();
            }
            else
            {
                _Status.Pause();
                TMainTimer.Stop();
            }
        }

        private void ChkStartStop_CheckedChanged(object sender, EventArgs e)
        {
            UpdateStartStopCheckBox();
            SetRunningState(ChkStartStop.Checked);
        }

        private void LoadFormWithStatus()
        {
            LbCurrentPeriod.Text = _Status.CurrentPeriod.ToString();
            LbCountDown.Text = _Status.GetReminingDurationString();
            ChkStartStop.Checked = _Status.IsRunning;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadFormWithStatus();
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
            bool IsAppPausedByUser = !_Status.IsRunning;

            if (!IsAppPausedByUser)
                ChkStartStop.Checked = false; // pause app

            if (FrmSettings.EditSettings(_Status) == FrmSettings.EnEditSettingsResult.Edited)
                UpdatePeriodInfoInUI();

            if (!IsAppPausedByUser)
                ChkStartStop.Checked = true; // resume app
        }

        private void UpdateCountDownLabel()
        {
            LbCountDown.Text = _Status.GetReminingDurationString();
        }

        private void UpdatePeriodInfoInUI()
        {
            LbCurrentPeriod.Text = _Status.CurrentPeriod.ToString();
            UpdateCountDownLabel();
        }

        private void TMainTimer_Tick(object sender, EventArgs e)
        {
            _Status.NumberOfSecondsRemainig--;
            UpdateCountDownLabel();

            if (_Status.NumberOfSecondsRemainig == 0)
            {
                TMainTimer.Stop();
                _Status.CurrentPeriod.ShowEndAlarm();
                _Status.SwitchPeriods();
                UpdatePeriodInfoInUI();
                TMainTimer.Start();
            }
        }
    
    }
}
