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
        private readonly NotifyIcon _NiError = null;
        private readonly FrmAlarmOverlay _ParentOverlayForm = null;
        private readonly bool _IsChild = false;
        private FrmAlarmOverlay[] _ChildOverlays = null;
        private Screen _ScreenToShowOverlayOn = null;

        // Base constructor
        private FrmAlarmOverlay(string AlarmMessage)
        {
            InitializeComponent();
            LbAlarmMessage.Text = AlarmMessage;
            this.StartPosition = FormStartPosition.Manual; // this is importent
        }

        // Parent must not be null, this is child alarm form constructor 
        private FrmAlarmOverlay(string AlarmMessage, FrmAlarmOverlay Parent, Screen ScreenToShowOverlayOn)
            : this(AlarmMessage)
        {
            _ParentOverlayForm = Parent;
            _IsChild = true;
            _ScreenToShowOverlayOn = ScreenToShowOverlayOn;

            this.Location = _ScreenToShowOverlayOn.Bounds.Location;

            _ParentOverlayForm.FormClosed += _Parent_FormClosed;
        }
       
        // Parent alarm form constructors
        private FrmAlarmOverlay(string AlarmMessage, ushort ShowTimeInSeconds = 30)
         : this(AlarmMessage)
        {
            _ScreenToShowOverlayOn = Screen.PrimaryScreen;

            this.Location = _ScreenToShowOverlayOn.Bounds.Location;

            TShowTimer.Interval = ShowTimeInSeconds * NUMBER_OF_MILLISECONDS_IN_A_SECOND;
            _NiError = new NotifyIcon();
            _NiError.Text = "EasyRest";
            _NiError.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            _NiError.Visible = false;
            _NiError.BalloonTipClosed += _NiError_BalloonTipClosed;
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

        private void _NiError_BalloonTipClosed(object sender, EventArgs e)
        {
            _NiError.Visible = false;
        }

        private void _Parent_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void DisplayChildOverlaysOnAllScreensIfAny()
        {
            Screen[] AllScreens = Screen.AllScreens;

            if (AllScreens.Length > 1)
            {
                _ChildOverlays = new FrmAlarmOverlay[AllScreens.Length - 1];

                int ChildOverlaysIndex = 0;
                for (int ScreensIndex = 0; ScreensIndex < AllScreens.Length; ScreensIndex++)
                {
                    if (AllScreens[ScreensIndex].Primary) continue;

                    _ChildOverlays[ChildOverlaysIndex] = new FrmAlarmOverlay(LbAlarmMessage.Text, this, AllScreens[ScreensIndex]);
                    _ChildOverlays[ChildOverlaysIndex].Show();

                    ChildOverlaysIndex++;
                }
            }
        }

        private void FrmAlarmOverlay_Load(object sender, System.EventArgs e)
        {
            if (_IsChild) return;

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
            if (_IsChild)
                _ParentOverlayForm.CloseAlarm();
            else
                CloseAlarm();
        }

        private void FrmAlarmOverlay_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_IsSoundPlaying)
                _AlarmSoundPlayer.Stop();
        }

        private void FrmAlarmOverlay_Shown(object sender, EventArgs e)
        {
            if (_IsChild) return;

            DisplayChildOverlaysOnAllScreensIfAny();
        }
    }
}
