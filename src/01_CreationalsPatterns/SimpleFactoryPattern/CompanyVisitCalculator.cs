namespace SimpleFactoryPattern
{
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

}
