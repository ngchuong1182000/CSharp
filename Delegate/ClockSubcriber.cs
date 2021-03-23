using System;

namespace Delegate
{
    public class ClockSubcriber
    {
        public void Subscribe(ClockPublisher publisher)
        {
            publisher.SecondChange += new ClockPublisher.SecondChangeHandler(TimeHasChange);
        }
        private void TimeHasChange(ClockPublisher clockPublisher, Clock time)
        {
            Console.WriteLine($"The current time is{time.Hour} : {time.Minute} : {time.Second}");
        }
    }
}