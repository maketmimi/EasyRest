using EasyRest.Properties;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace EasyRest.UI
{
    public partial class FrmAlarmOverlay : Form
    {
        private static readonly short NUMBER_OF_MILLISECONDS_IN_A_SECOND = 1000;
        private readonly SoundPlayer AlarmSound = new SoundPlayer(Resources.DefaultAlarmSound);


        public FrmAlarmOverlay(string AlarmMessage, ushort ShowTimeInSeconds = 30)
        {
            InitializeComponent();
            TShowTimer.Interval = ShowTimeInSeconds * NUMBER_OF_MILLISECONDS_IN_A_SECOND;
            LbAlarmMessage.Text = AlarmMessage;
        }

        private void FrmAlarmOverlay_Load(object sender, System.EventArgs e)
        {
            TShowTimer.Enabled = true;

            AlarmSound.PlayLooping();
        }

        private void CloseAlarm()
        {
            TShowTimer.Enabled = false;
            this.Close();
        }

        private void TShowTimer_Tick(object sender, System.EventArgs e)
        {
            CloseAlarm();
        }

        private void BtnClose_Click(object sender, System.EventArgs e)
        {
            CloseAlarm();
        }

        private void FrmAlarmOverlay_FormClosed(object sender, FormClosedEventArgs e)
        {
            AlarmSound.Stop();
        }
    }
}
