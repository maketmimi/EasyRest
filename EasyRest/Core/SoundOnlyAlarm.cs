using EasyRest.Properties;
using System.Media;
using System.Windows.Forms;

namespace EasyRest.Core
{
    public class SoundOnlyAlarm
    {
        public static void PlayAlarm(ushort TimeOutInSeconds)
        {
            new SoundOnlyAlarm(TimeOutInSeconds)._PlayAlarm();
        }

        private readonly SoundPlayer _DefaultAlarmSound = new SoundPlayer(Resources.DefaultAlarmSound);
        private Timer _PlayTimer = new Timer();

        private SoundOnlyAlarm(ushort TimeOutInSeconds)
        {
            _PlayTimer.Tick += _PlayTimer_Tick;
            _PlayTimer.Interval = TimeOutInSeconds * 1000;
        }

        private void _PlayAlarm()
        {
            _DefaultAlarmSound.PlayLooping();
            _PlayTimer.Start();
        }

        private void _PlayTimer_Tick(object sender, System.EventArgs e)
        {
            _PlayTimer.Stop();
            _DefaultAlarmSound.Stop();
        }
    
    }
}
