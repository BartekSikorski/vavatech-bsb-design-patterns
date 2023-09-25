namespace SimpleFactoryPattern
{
    // Concrete Product C
    public class CompanyVisit : Visit
    {
        private decimal companyDiscountPercentage;

        public CompanyVisit(TimeSpan duration, decimal pricePerHour, decimal companyDiscountPercentage) : base(duration, pricePerHour)
        {
            this.companyDiscountPercentage = companyDiscountPercentage;
        }

        public override decimal CalculateCost()
        {
            return (decimal)Duration.TotalHours * PricePerHour * companyDiscountPercentage;
        }
    }

    public class TeleVisit : Visit
    {
        public TeleVisit(TimeSpan duration, decimal pricePerHour) : base(duration, pricePerHour)
        {
        }

        public override decimal CalculateCost()
        {
            throw new NotImplementedException();
        }
    }

}
