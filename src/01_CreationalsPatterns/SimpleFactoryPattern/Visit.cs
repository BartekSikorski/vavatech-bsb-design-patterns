using System;

namespace SimpleFactoryPattern
{
    public interface IValidator<T>
    {
        bool Validate(T value);
    }

    public class VisitValidator : IValidator<Visit>
    {
        public bool Validate(Visit value)
        {
            Validate(value.Duration);

            return true;
        }

        private static void Validate(TimeSpan duration)
        {
            if (duration < TimeSpan.Zero)
            {
                throw new ArgumentOutOfRangeException(nameof(duration));
            }
        }
    }

    // Abstract Product
    public abstract class Visit
    {
        public DateTime VisitDate { get; set; }
        public TimeSpan Duration { get; set; }
        public decimal PricePerHour { get; set; }

        public Visit(TimeSpan duration, decimal pricePerHour)
        {
            VisitDate = DateTime.Now;
            Duration = duration;
            PricePerHour = pricePerHour;
        }

      

        public abstract decimal CalculateCost();
    }

}
