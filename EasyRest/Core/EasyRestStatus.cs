using System;

namespace EasyRest.Core
{
    public class EasyRestStatus
    {
        public ulong NumberOfSecondsRemainig { get; set; }
        public Period RestPeriod { get; }
        public Period WorkPeriod { get; }

        private Period _CurrentPeriod;
        public Period CurrentPeriod
        {
            get
            {
                return _CurrentPeriod;
            }

            set
            {
                if (value != null)
                {
                    _CurrentPeriod = value;
                    NumberOfSecondsRemainig = ((ulong)_CurrentPeriod.Duration.TotalSeconds);
                }
            }

        }
        public bool IsRunning { get; set; }

        public void SwitchPeriods()
        {
            if (CurrentPeriod.Title == RestPeriod.Title)
                CurrentPeriod = WorkPeriod;
            else
                CurrentPeriod = RestPeriod;
        }

        public void Pause()
        {
            IsRunning = false;
        }

        public void Start()
        {
            IsRunning = true;
        }

        // this returns the string of the remining seconds in Minutes:Seconds format
        public string GetReminingDurationString()
        {
            return $"{NumberOfSecondsRemainig / 60:D2}:{NumberOfSecondsRemainig % 60:D2}";
        }

        public EasyRestStatus()
        {
            RestPeriod = new Period("فترة الراحة", "لقد حان وقت العمل", new TimeSpan(0, 10, 0));
            WorkPeriod = new Period("فترة العمل", "لقد حان وقت الراحة", new TimeSpan(0, 20, 0));

            CurrentPeriod = WorkPeriod;

            IsRunning = false;
        }
    
    }
}
