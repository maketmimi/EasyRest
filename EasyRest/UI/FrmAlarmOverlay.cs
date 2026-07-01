using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace EasyRest.UI
{
    public partial class FrmAlarmOverlay : Form
    {
        private static readonly short NUMBER_OF_MILLISECONDS_IN_A_SECOND = 1000;
        private readonly SoundPlayer _AlarmSoundPlayer;
        private bool _IsSoundPlaying = false;
        private readonly NotifyIcon _NiError = new NotifyIcon();

        private FrmAlarmOverlay(string AlarmMessage, ushort ShowTimeInSeconds = 30)
        {
            InitializeComponent();
            TShowTimer.Interval = ShowTimeInSeconds * NUMBER_OF_MILLISECONDS_IN_A_SECOND;
            LbAlarmMessage.Text = AlarmMessage;                                  
            _NiError.Text = "EasyRest";
            _NiError.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            _NiError.Visible = false;
            _NiError.BalloonTipClosed += _NiError_BalloonTipClosed;
        }

        private void _NiError_BalloonTipClosed(object sender, EventArgs e)
        {
            _NiError.Visible = false;
        }

        public FrmAlarmOverlay(string AlarmMessage, string AlarmSoundPath, ushort ShowTimeInSeconds = 30)
            : this(AlarmMessage, ShowTimeInSeconds)
        {
            _AlarmSoundPlayer = new SoundPlayer(AlarmSoundPath);
        }

        public FrmAlarmOverlay(string AlarmMessage, Stream AlarmSound, ushort ShowTimeInSeconds = 30)
            : this(AlarmMessage, ShowTimeInSeconds)
        {
            _AlarmSoundPlayer = new SoundPlayer(AlarmSound);
        }


        private void FrmAlarmOverlay_Load(object sender, System.EventArgs e)
        {
            try
            {
                _AlarmSoundPlayer.PlayLooping();
                _IsSoundPlaying = true;
            }
            catch (FileNotFoundException)
            {
                _NiError.Visible = true; 
                _NiError.ShowBalloonTip(10000, "خطأ", "لم يتم العثور على الملف الصوتي التالي" + Environment.NewLine + _AlarmSoundPlayer.SoundLocation, ToolTipIcon.Error);
            }
            catch
            {
                _NiError.Visible = true; 
                _NiError.ShowBalloonTip(10000, "خطأ", "حدث خطأ أثناء تحميل الملف الصوتي التالي" + Environment.NewLine + _AlarmSoundPlayer.SoundLocation, ToolTipIcon.Error);
            }

            TShowTimer.Start();
        }

        private void CloseAlarm()
        {
            TShowTimer.Stop();
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
            if (_IsSoundPlaying)
                _AlarmSoundPlayer.Stop();
        }
    }
}
