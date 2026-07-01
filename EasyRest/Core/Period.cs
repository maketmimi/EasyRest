using EasyRest.Properties;
using EasyRest.UI;
using System;
using System.IO;

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
        // path to .wav alarm sound, null or white space means Default sound
        private string _AlarmSoundPath;
        public string AlarmSoundPath {
            set
            {
                _AlarmSoundPath = value;
            }

            get
            {
                return String.IsNullOrWhiteSpace(_AlarmSoundPath) ? "" : _AlarmSoundPath;
            }
        
        }

        public Period(string title, string endOfPeriodMessage, TimeSpan duration, EnAlarmType alarmType, string AlarmSoundPath)
        {
            Title = title;
            Duration = duration;
            EndOfPeriodMessage = endOfPeriodMessage;
            AlarmType = alarmType;
            this.AlarmSoundPath = AlarmSoundPath;
        }

        private void ShowScreenOverlayAlarm()
        {
            FrmAlarmOverlay frmAlarm;

            switch (ValidateAlarmSoundFile())
            {
                case EnValidateSoundFileResult.Valid:
                    frmAlarm = new FrmAlarmOverlay(EndOfPeriodMessage, AlarmSoundPath, 20);
                    break;
                default:
                    frmAlarm = new FrmAlarmOverlay(EndOfPeriodMessage, Resources.DefaultAlarmSound, 20);
                    break;
            }

            frmAlarm.ShowDialog();
        }

        private void ShowNotificationAlarm()
        {
            NotificationAlarm.ShowAlarm(EndOfPeriodMessage);
        }
                
        private void PlaySoundOnlyAlarm()
        {
            if (ValidateAlarmSoundFile() == EnValidateSoundFileResult.Valid)
                SoundOnlyAlarm.PlayAlarm(10, AlarmSoundPath);
            else
                SoundOnlyAlarm.PlayAlarm(10, Resources.DefaultAlarmSound);
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
            return string.Join(_RecordSeperator, Title, EndOfPeriodMessage, Duration.TotalSeconds, AlarmType, AlarmSoundPath);
        }

        public static Period ConvertStringRecordToPeriod(string Record)
        {
            string[] arrRecord = Record.Split(new[] { _RecordSeperator }, StringSplitOptions.None);

            try
            {
                return new Period(arrRecord[0], arrRecord[1], TimeSpan.FromSeconds(int.Parse(arrRecord[2])), (EnAlarmType) Enum.Parse(typeof(EnAlarmType), arrRecord[3]), arrRecord[4]);
            }
            catch
            {
                return null;
            }
        }

        public enum EnValidateSoundFileResult
        {
            Default,
            Valid,
            FileNotFound,
            InvalidFormat
        }

        public EnValidateSoundFileResult ValidateAlarmSoundFile()
        {
            // TODO we should vaildate that the file is .wav as well in future

            if (String.IsNullOrWhiteSpace(_AlarmSoundPath))
                return EnValidateSoundFileResult.Default;
            else if (!File.Exists(_AlarmSoundPath))
                return EnValidateSoundFileResult.FileNotFound;
            else
                return EnValidateSoundFileResult.Valid;
        }

        public bool IsDefaultSound()
        {
            return ValidateAlarmSoundFile() == EnValidateSoundFileResult.Default;
        }

    }
}
