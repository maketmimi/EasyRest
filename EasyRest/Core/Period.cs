using EasyRest.UI;
using System;

namespace EasyRest.Core
{
    public class Period
    {
        public enum EnAlarmType
        {
            NotificationsOnly,
            SoundOnly,
            ScreenOverlay
        }

        public string Title { get; set; }
        public TimeSpan Duration { get; set; }
        public string EndOfPeriodMessage { get; set; }
        private static readonly string _RecordSeperator = "[PSep]";
        public EnAlarmType AlarmType { get; set; }

        public Period(string title, string endOfPeriodMessage, TimeSpan duration, EnAlarmType alarmType)
        {
            Title = title;
            Duration = duration;
            EndOfPeriodMessage = endOfPeriodMessage;
            AlarmType = alarmType;
        }

        private void ShowScreenOverlayAlarm()
        {
            FrmAlarmOverlay frmAlarm = new FrmAlarmOverlay(EndOfPeriodMessage, 20);

            frmAlarm.ShowDialog();
        }

        private void ShowNotificationAlarm()
        {
            NotificationAlarm.ShowAlarm(EndOfPeriodMessage);
        }
                
        private void PlaySoundOnlyAlarm()
        {
            // TODO try to implement a method that plays a sound in another thread for a specified timeout

            SoundOnlyAlarm.PlayAlarm(10);
        }

        public void ShowEndAlarm()
        {
            switch (AlarmType)
            {
                case EnAlarmType.NotificationsOnly:
                    ShowNotificationAlarm();
                    break;
                case EnAlarmType.SoundOnly:
                    PlaySoundOnlyAlarm();
                    break;
                default:
                    ShowScreenOverlayAlarm();
                    break;
            }
        }

        public override string ToString()
        {
            return Title;
        }
    
        public string ConvertToStringRecord()
        {
            return string.Join(_RecordSeperator, Title, EndOfPeriodMessage, Duration.TotalSeconds, AlarmType);
        }

        public static Period ConvertStringRecordToPeriod(string Record)
        {
            string[] arrRecord = Record.Split(new[] { _RecordSeperator }, StringSplitOptions.None);

            try
            {
                return new Period(arrRecord[0], arrRecord[1], TimeSpan.FromSeconds(int.Parse(arrRecord[2])), (EnAlarmType) Enum.Parse(typeof(EnAlarmType), arrRecord[3]));
            }
            catch
            {
                return null;
            }

        }

    }
}
