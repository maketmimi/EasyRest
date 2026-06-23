using EasyRest.Core;
using EasyRest.Properties;
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

        private void LoadUserSavedConfigsIfAny()
        {
            EasyRestStatus LoadedStatus = EasyRestStatus.ConvertStringRecordToStatusObject(Settings.Default.UserSavedConfigs);

            if (LoadedStatus != null)
                _Status = LoadedStatus;
        }

        private void SaveUserConfigs()
        {
            Settings.Default.UserSavedConfigs = _Status.ConvertToStringRecord();
            Settings.Default.Save();
        }

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
            LoadUserSavedConfigsIfAny();
            LoadFormWithStatus();
            LoadSettingsPageWithCurrentSettings();
            AddPeriodsToCbCurrentPeriod();
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

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveUserConfigs();
        }

        private void LLbGithubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LLbGithubLink.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/maketmimi");
        }

        private void PbAppLogo_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/maketmimi/EasyRest");
        }

        private void SetAlarmTypeToPeriod(string AlarmType, Period period)
        {
            switch (AlarmType)
            {
                case "تنبيه بالإشعارات":
                    period.AlarmType = Period.EnAlarmType.NotificationsOnly;
                    break;
                case "تنبيه صوتي":
                    period.AlarmType = Period.EnAlarmType.SoundOnly;
                    break;
                default:
                    period.AlarmType = Period.EnAlarmType.ScreenOverlay;
                    break;
            }
        }

        private void ApplySettings()
        {
            _Status.WorkPeriod.Duration = new TimeSpan(0, ((int)NudWorkDuration.Value), 0);
            _Status.RestPeriod.Duration = new TimeSpan(0, ((int)NudRestDuration.Value), 0);

            SetAlarmTypeToPeriod(CbWorkPeriodAlarmType.SelectedItem.ToString(), _Status.WorkPeriod);
            SetAlarmTypeToPeriod(CbRestPeriodAlarmType.SelectedItem.ToString(), _Status.RestPeriod);

            _Status.CurrentPeriod = (Period)CbCurrentPeriod.SelectedItem; // this should be here, or there might be logical error
        }

        private void LoadComboBoxWithCurrentSelectedAlarmType(ComboBox cbToLoad, Period.EnAlarmType AlarmType)
        {
            switch (AlarmType)
            {
                case Period.EnAlarmType.NotificationsOnly:
                    cbToLoad.SelectedItem = "تنبيه بالإشعارات";
                    break;
                case Period.EnAlarmType.SoundOnly:
                    cbToLoad.SelectedItem = "تنبيه صوتي";
                    break;
                default:
                    cbToLoad.SelectedItem = "تنبيه ملء الشاشة";
                    break;
            }
        }

        private void LoadCbCurrentPeriodWithCurrentPeriod()
        {
            CbCurrentPeriod.SelectedItem = _Status.CurrentPeriod;
        }

        private void AddPeriodsToCbCurrentPeriod()
        {
            CbCurrentPeriod.Items.Add(_Status.WorkPeriod);
            CbCurrentPeriod.Items.Add(_Status.RestPeriod);
        }

        private void LoadSettingsPageWithCurrentSettings()
        {
            LoadCbCurrentPeriodWithCurrentPeriod();

            NudWorkDuration.Value = ((decimal)_Status.WorkPeriod.Duration.TotalMinutes);
            NudRestDuration.Value = ((decimal)_Status.RestPeriod.Duration.TotalMinutes);

            LoadComboBoxWithCurrentSelectedAlarmType(CbWorkPeriodAlarmType, _Status.WorkPeriod.AlarmType);
            LoadComboBoxWithCurrentSelectedAlarmType(CbRestPeriodAlarmType, _Status.RestPeriod.AlarmType);
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            ApplySettings();
            UpdatePeriodInfoInUI();
            MessageBox.Show("تم التعديل بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
        }

        private void TabMain_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == 1) // Settings Page
            {
                LoadSettingsPageWithCurrentSettings();
            }
        }
    }
}
