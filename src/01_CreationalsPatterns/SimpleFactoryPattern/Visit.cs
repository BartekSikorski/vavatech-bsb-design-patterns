using System;

namespace SimpleFactoryPattern
{

    public class PrivateVisitCalculator : IVisitCalculator
    {
        private decimal PricePerHour;

        public PrivateVisitCalculator(decimal pricePerHour)
        {
            this.PricePerHour = pricePerHour;
        }

        public decimal CalculateCost(Visit visit)
        {
            return (decimal)visit.Duration.TotalHours * PricePerHour;
        }
    }

    public class CompanyVisitCalculator : IVisitCalculator
    {
        private decimal PricePerHour;
        private decimal companyDiscountPercentage;

        public CompanyVisitCalculator(decimal pricePerHour, decimal companyDiscountPercentage)
        {
            PricePerHour = pricePerHour;
            this.companyDiscountPercentage = companyDiscountPercentage;
        }

        public decimal CalculateCost(Visit visit)
        {
            return (decimal)visit.Duration.TotalHours * PricePerHour * companyDiscountPercentage;
        }
    }

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
