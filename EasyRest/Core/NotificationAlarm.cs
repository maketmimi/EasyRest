using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyRest.Core
{
    internal class NotificationAlarm
    {
        public static void ShowAlarm(string EndOfPeriodMessage)
        {
            NotifyIcon NAlarm = new NotifyIcon();
            NAlarm.BalloonTipClosed += NAlarm_BalloonTipClosed;

            NAlarm.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            NAlarm.BalloonTipIcon = ToolTipIcon.Info;
            NAlarm.BalloonTipTitle = "تنبيه";
            NAlarm.BalloonTipText = EndOfPeriodMessage;
            NAlarm.Visible = true;
            NAlarm.ShowBalloonTip(10000);
        }

        private static void NAlarm_BalloonTipClosed(object sender, EventArgs e)
        {
            ((NotifyIcon)sender).Visible = false;
        }
    }
}
