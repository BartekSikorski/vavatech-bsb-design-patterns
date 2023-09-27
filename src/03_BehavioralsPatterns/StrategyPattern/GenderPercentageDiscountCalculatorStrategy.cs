namespace StrategyPattern
{
    // Gender - 20% upustu dla kobiet
    public class GenderPercentageDiscountCalculatorStrategy : IDiscountCalculatorStrategy
    {
        private readonly Gender gender;

        private readonly decimal percentage;

        public GenderPercentageDiscountCalculatorStrategy(Gender gender, decimal percentage)
        {
            this.gender = gender;
            this.percentage = percentage;
        }

        public decimal NoDiscount => decimal.Zero;
        public bool CanDiscount(Order order) => order.Customer.Gender == gender;
        public decimal Discount(Order order) => order.Amount * percentage;
    }
}
