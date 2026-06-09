using EasyRest.UI;
using System;

namespace EasyRest.Core
{
    public class Period
    {
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }
        public string EndOfPeriodMessage { get; set; }

        public Period(string title, string endOfPeriodMessage, TimeSpan duration)
        {
            Title = title;
            Duration = duration;
            EndOfPeriodMessage = endOfPeriodMessage;
        }

        public void ShowEndAlarm()
        {
            FrmAlarmOverlay frmAlarm = new FrmAlarmOverlay(EndOfPeriodMessage, 20);

            frmAlarm.ShowDialog(); // TODO make sure this is ok or maybe using the show() method instead
        }

        public override string ToString()
        {
            return Title;
        }
    
    }
}
