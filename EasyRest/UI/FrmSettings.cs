using EasyRest.Core;
using System;
using System.Windows.Forms;

namespace EasyRest.UI
{
    public partial class FrmSettings : Form
    {
        private EasyRestStatus _Configs;
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

        private void ApplySettings()
        {
            _Configs.WorkPeriod.Duration = new TimeSpan(0, ((int)NudWorkDuration.Value), 0);
            _Configs.RestPeriod.Duration = new TimeSpan(0, ((int)NudRestDuration.Value), 0);
            _Configs.CurrentPeriod = (Period) CbCurrentPeriod.SelectedItem; // this should be here, or there might be logical error

            _EditResult = EnEditSettingsResult.Edited;
        }

        private void BtnApply_Click(object sender, System.EventArgs e)
        {
            ApplySettings();
            this.Close();
        }

        private void LoadFormWithCurrentSettings()
        {
            CbCurrentPeriod.Items.Add(_Configs.WorkPeriod);
            CbCurrentPeriod.Items.Add(_Configs.RestPeriod);
            CbCurrentPeriod.SelectedItem = _Configs.CurrentPeriod;

            NudWorkDuration.Value = ((decimal)_Configs.WorkPeriod.Duration.TotalMinutes);
            NudRestDuration.Value = ((decimal)_Configs.RestPeriod.Duration.TotalMinutes);
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
