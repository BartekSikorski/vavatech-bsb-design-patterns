using System;

namespace SimpleFactoryPattern
{

    public class Visit
    {
        public DateTime VisitDate { get; set; }
        public TimeSpan Duration { get; set; }

        public Visit(TimeSpan duration)
        {
            VisitDate = DateTime.Now;
            Duration = duration;
        }

      

        
    }

}
