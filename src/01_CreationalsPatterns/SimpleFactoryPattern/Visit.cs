using System;

namespace SimpleFactoryPattern
{
    public class Visit
    {
        public DateTime VisitDate { get; set; }
        public TimeSpan Duration { get; set; }
        public decimal PricePerHour { get; set; }

        private const decimal companyDiscountPercentage = 0.9m;

        public Visit(TimeSpan duration, decimal pricePerHour)
        {
            VisitDate = DateTime.Now;
            Duration = duration;
            PricePerHour = pricePerHour;
        }

        public decimal CalculateCost(VisitType kind)
        {
            decimal cost = 0;

            switch (kind)         
            {
                case VisitType.Nfz: 
                    cost = 0;
                    break;
                case VisitType.Private:
                    cost = (decimal)Duration.TotalHours * PricePerHour;
                    break;
                case VisitType.Company:
                    cost = (decimal)Duration.TotalHours * PricePerHour * companyDiscountPercentage;
                    break;
            }

            return cost;
        }
    }


    public enum VisitType
    {
        Nfz,
        Private,
        Company

    }
}
