using EasyRest.Core;
using EasyRest.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EasyRest
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            _IsAppInitializing = true;

            InitializeComponent();
            LoadUserSavedConfigsIfAny();
            LoadFormWithStatus();
            AddPeriodsToComboBox(CbCurrentPeriod);
            AddPeriodsToComboBox(CbPeriodToSetSoundFor);
            LoadSettingsPageWithCurrentSettings();
            CheckAlarmSoundFilesIfAny(_Status.WorkPeriod);
            CheckAlarmSoundFilesIfAny(_Status.RestPeriod);
            
            _IsAppInitializing = false;
        }

        private bool _IsClosedByXButton = true;
        private bool _IsAppInitializing;
        private EasyRestStatus _Status = new EasyRestStatus(true); 

        private void CheckAlarmSoundFilesIfAny(Period period)
        {
            switch (period.ValidateAlarmSoundFile())
            {
                case Period.EnValidateSoundFileResult.FileNotFound:
                case Period.EnValidateSoundFileResult.InvalidFormat:
                    NiEasyRest.ShowBalloonTip(10000, "خطأ", "حدث خطأ أثناء تحميل الملف الصوتي التالي" + Environment.NewLine + period.AlarmSoundPath, ToolTipIcon.Error);
                    break;
            }
        }

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
                _Status.IsRunning ?
                Color.FromArgb(0, 192, 0) :
                Color.FromArgb(192, 0, 0);

            ChkStartStop.BackColor = ColorToSet;
            ChkStartStop.FlatAppearance.MouseDownBackColor = ColorToSet;
            ChkStartStop.FlatAppearance.MouseOverBackColor = ColorToSet;

            ChkStartStop.Text =
                _Status.IsRunning ?
                "يعمل" : "متوقف";

            ChkStartStop.Checked = _Status.IsRunning;
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

        private void ChkStartStop_Clicked(object sender, EventArgs e)
        {
            SetRunningState(ChkStartStop.Checked);
            UpdateStartStopCheckBox();
            UpdateStartStopTsmi();
        }

        private void LoadFormWithStatus()
        {
            LbCurrentPeriod.Text = _Status.CurrentPeriod.ToString();
            LbCountDown.Text = _Status.GetReminingDurationString();
            ChkStartStop.Checked = _Status.IsRunning;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void CloseAppProgramaticlly()
        {
            _IsClosedByXButton = false;
            Application.Exit();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            CloseAppProgramaticlly();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_IsClosedByXButton)
            {
                e.Cancel = true;
                this.Hide();
            }
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

        private void LoadComboBoxWithCurrentPeriod(ComboBox comboBox)
        {
            comboBox.SelectedItem = _Status.CurrentPeriod;
        }

        private void AddPeriodsToComboBox(ComboBox comboBox)
        {
            comboBox.Items.Add(_Status.WorkPeriod);
            comboBox.Items.Add(_Status.RestPeriod);
        }

        private void InitializeRunOnStartupCheckBox()
        {
            ChkRunAppOnStartup.Checked = WindowsHelpers.IsAppStartupWhenUserLoggesInEnabled();
        }

        private void LoadSettingsPageWithCurrentSettings()
        {
            LoadComboBoxWithCurrentPeriod(CbCurrentPeriod);
            LoadComboBoxWithCurrentPeriod(CbPeriodToSetSoundFor);

            NudWorkDuration.Value = ((decimal)_Status.WorkPeriod.Duration.TotalMinutes);
            NudRestDuration.Value = ((decimal)_Status.RestPeriod.Duration.TotalMinutes);

            LoadComboBoxWithCurrentSelectedAlarmType(CbWorkPeriodAlarmType, _Status.WorkPeriod.AlarmType);
            LoadComboBoxWithCurrentSelectedAlarmType(CbRestPeriodAlarmType, _Status.RestPeriod.AlarmType);
            InitializeRunOnStartupCheckBox();
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            ApplySettings();
            SaveUserConfigs();
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

        private void UpdateAlarmSoundSettingsInfoInUi()
        {
            if (((Period)CbPeriodToSetSoundFor.SelectedItem).IsDefaultSound())
                TxtSoundFileName.Text = "الصوت الإفتراضي";
            else
                TxtSoundFileName.Text = Path.GetFileName(((Period)CbPeriodToSetSoundFor.SelectedItem).AlarmSoundPath);
        } 

        private void CbPeriodToSetSoundFor_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAlarmSoundSettingsInfoInUi();
        }

        private void BtnSetDefaultAlarmSound_Click(object sender, EventArgs e)
        {
            ((Period)CbPeriodToSetSoundFor.SelectedItem).AlarmSoundPath = null; // means default sound
            UpdateAlarmSoundSettingsInfoInUi();
        }

        private void BtnBrowseAlarmSound_Click(object sender, EventArgs e)
        {
            OpenFALarmSound.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic, Environment.SpecialFolderOption.None);
        
            if (OpenFALarmSound.ShowDialog() == DialogResult.OK)
            {
                ((Period)CbPeriodToSetSoundFor.SelectedItem).AlarmSoundPath = OpenFALarmSound.FileName;
                UpdateAlarmSoundSettingsInfoInUi();
            }
        }

        private void UpdateStartStopTsmi()
        {
            Color ColorToSet =
                _Status.IsRunning ?
                Color.FromArgb(0, 192, 0) :
                Color.FromArgb(192, 0, 0);

            startStopToolStripMenuItem.ForeColor = ColorToSet;

            startStopToolStripMenuItem.Text =
                _Status.IsRunning ?
                "يعمل" : "متوقف";

            startStopToolStripMenuItem.Checked = _Status.IsRunning;
        }

        private void startStopToolStripMenuItem_click(object sender, EventArgs e)
        {
            SetRunningState(startStopToolStripMenuItem.Checked);
            UpdateStartStopCheckBox();
            UpdateStartStopTsmi();
        }

        private void showAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAppProgramaticlly();
        }

        private void NiEasyRest_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.Show();
        }

        private void hideAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CmTaskBarIcon_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.Visible)
            {
                hideAppToolStripMenuItem.Enabled = true;
                showAppToolStripMenuItem.Enabled = false;
            }
            else
            {
                hideAppToolStripMenuItem.Enabled = false;
                showAppToolStripMenuItem.Enabled = true;
            }
        }

        private void openSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabMain.SelectedIndex = 1;
            this.Show();
        }

        private void ChkRunAppOnStartup_CheckedChanged(object sender, EventArgs e)
        {
            if (_IsAppInitializing) return;

            WindowsHelpers.ChangeAppStartupWhenUserLoggesIn(ChkRunAppOnStartup.Checked);
        }
    }
}
