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

}
