using EasyRest.UI;
using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace EasyRest.Core
{
    public class Period
    {
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }
        public string EndOfPeriodMessage { get; set; }
        private static readonly string _RecordSeperator = "[PSep]";

        public Period(string title, string endOfPeriodMessage, TimeSpan duration)
        {
            Title = title;
            Duration = duration;
            EndOfPeriodMessage = endOfPeriodMessage;
        }

        public void ShowEndAlarm()
        {
            FrmAlarmOverlay frmAlarm = new FrmAlarmOverlay(EndOfPeriodMessage, 20);

            frmAlarm.ShowDialog();
        }

        public override string ToString()
        {
            return Title;
        }
    
        public string ConvertToStringRecord()
        {
            return string.Join(_RecordSeperator, Title, EndOfPeriodMessage, Duration.TotalSeconds);
        }

        public static Period ConvertStringRecordToPeriod(string Record)
        {
            string[] arrRecord = Record.Split(new[] { _RecordSeperator }, StringSplitOptions.None);

            try
            {
                return new Period(arrRecord[0], arrRecord[1], TimeSpan.FromSeconds(int.Parse(arrRecord[2])));
            }
            catch
            {
                return null;
            }

        }

    }
}
