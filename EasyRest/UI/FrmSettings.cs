using EasyRest.Core;
using System;
using System.Windows.Forms;

namespace EasyRest.UI
{
    public partial class FrmSettings : Form
    {
        private readonly EasyRestStatus _Configs;
        private EnEditSettingsResult _EditResult = EnEditSettingsResult.Canceld;

        public enum EnEditSettingsResult
        {
            Edited,
            Canceld,
            Failed
        }

        private FrmSettings(EasyRestStatus Status)
        {
            InitializeComponent();
            _Configs = Status;
        }

        public static EnEditSettingsResult EditSettings(EasyRestStatus Status)
        {
            if (Status == null) return EnEditSettingsResult.Failed;

            FrmSettings frmSettings = new FrmSettings(Status);

            frmSettings.ShowDialog();

            return frmSettings._EditResult;
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
            _Configs.WorkPeriod.Duration = new TimeSpan(0, ((int)NudWorkDuration.Value), 0);
            _Configs.RestPeriod.Duration = new TimeSpan(0, ((int)NudRestDuration.Value), 0);

            SetAlarmTypeToPeriod(CbWorkPeriodAlarmType.SelectedItem.ToString(), _Configs.WorkPeriod);
            SetAlarmTypeToPeriod(CbRestPeriodAlarmType.SelectedItem.ToString(), _Configs.RestPeriod);

            _Configs.CurrentPeriod = (Period) CbCurrentPeriod.SelectedItem; // this should be here, or there might be logical error

            _EditResult = EnEditSettingsResult.Edited;
        }

        private void BtnApply_Click(object sender, System.EventArgs e)
        {
            ApplySettings();
            this.Close();
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

        private void LoadFormWithCurrentSettings()
        {
            CbCurrentPeriod.Items.Add(_Configs.WorkPeriod);
            CbCurrentPeriod.Items.Add(_Configs.RestPeriod);
            CbCurrentPeriod.SelectedItem = _Configs.CurrentPeriod;

            NudWorkDuration.Value = ((decimal)_Configs.WorkPeriod.Duration.TotalMinutes);
            NudRestDuration.Value = ((decimal)_Configs.RestPeriod.Duration.TotalMinutes);

            LoadComboBoxWithCurrentSelectedAlarmType(CbWorkPeriodAlarmType, _Configs.WorkPeriod.AlarmType);
            LoadComboBoxWithCurrentSelectedAlarmType(CbRestPeriodAlarmType, _Configs.RestPeriod.AlarmType);
        }

        private void FrmSettings_Load(object sender, System.EventArgs e)
        {
            LoadFormWithCurrentSettings();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            _EditResult = EnEditSettingsResult.Canceld;
            this.Close();
        }
    
    }
}
