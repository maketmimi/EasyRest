namespace EasyRest.Core
{
    public class EasyRestStatus
    {
        public ulong NumberOfSecondsRemainig { get; set; }
        public Period RestPeriod { get; }
        public Period WorkPeriod { get; }
        public Period CurrentPeriod { get; set; }
        public bool IsRunning { get; set; }

        public void SwitchPeriods()
        {
            if (CurrentPeriod.Title == RestPeriod.Title)
                CurrentPeriod = WorkPeriod;
            else
                CurrentPeriod = RestPeriod;

            NumberOfSecondsRemainig = ((ulong)CurrentPeriod.Duration.TotalSeconds);
        }

        public void Pause()
        {
            IsRunning = false;
        }

        public void Start()
        {
            IsRunning = true;
        }

        public EasyRestStatus(Period restPeriod, Period workPeriod)
        {
            RestPeriod = restPeriod;
            WorkPeriod = workPeriod;

            CurrentPeriod = workPeriod;
            NumberOfSecondsRemainig = ((ulong)CurrentPeriod.Duration.TotalSeconds);

            IsRunning = false;
        }
    
    }
}
