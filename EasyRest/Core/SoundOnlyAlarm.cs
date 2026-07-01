using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace EasyRest.Core
{
    public class SoundOnlyAlarm
    {
        public static void PlayAlarm(ushort TimeOutInSeconds, string AlarmSoundPath)
        {
            new SoundOnlyAlarm(TimeOutInSeconds, AlarmSoundPath)._PlayAlarm();
        }

        public static void PlayAlarm(ushort TimeOutInSeconds, Stream AlarmSound)
        {
            new SoundOnlyAlarm(TimeOutInSeconds, AlarmSound)._PlayAlarm();
        }

        private readonly SoundPlayer _AlarmSoundPlayer;
        private readonly Timer _PlayTimer = new Timer();
        private readonly NotifyIcon _NiError = new NotifyIcon();


        private SoundOnlyAlarm(ushort TimeOutInSeconds)
        {
            _PlayTimer.Tick += _PlayTimer_Tick;
            _PlayTimer.Interval = TimeOutInSeconds * 1000;
            _NiError.Text = "EasyRest";
            _NiError.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            _NiError.Visible = false;
            _NiError.BalloonTipClosed += NiError_BalloonTipClosed;
        }

        private SoundOnlyAlarm(ushort TimeOutInSeconds, string AlarmSoundPath) : this(TimeOutInSeconds)
        {
            _AlarmSoundPlayer = new SoundPlayer(AlarmSoundPath);
            _AlarmSoundPlayer.Load();
        }

        private SoundOnlyAlarm(ushort TimeOutInSeconds, Stream AlarmSound) : this(TimeOutInSeconds)
        {
            _AlarmSoundPlayer = new SoundPlayer(AlarmSound);
            _AlarmSoundPlayer.Load();
        }

        private void _PlayAlarm()
        {
            if (_AlarmSoundPlayer == null) return;

            try
            {
                _AlarmSoundPlayer.PlayLooping();
                _PlayTimer.Start();
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
        }

        // TODO we need to dispose the objects 
        private void NiError_BalloonTipClosed(object sender, EventArgs e)
        {
            _NiError.Visible = false;
        }

        private void _PlayTimer_Tick(object sender, EventArgs e)
        {
            _PlayTimer.Stop();
            _AlarmSoundPlayer.Stop();
        }
    
    }
}
