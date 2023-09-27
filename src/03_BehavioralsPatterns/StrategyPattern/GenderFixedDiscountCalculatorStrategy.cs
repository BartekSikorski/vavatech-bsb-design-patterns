namespace StrategyPattern
{
    public class GenderFixedDiscountCalculatorStrategy : IDiscountCalculatorStrategy
    {
        private readonly Gender gender;

        private readonly decimal amount;

        public GenderFixedDiscountCalculatorStrategy(Gender gender, decimal amount)
        {
            this.gender = gender;
            this.amount = amount;
        }

        public decimal NoDiscount => decimal.Zero;
        public bool CanDiscount(Order order) => order.Customer.Gender == gender;
        public decimal Discount(Order order) => amount;
    }
}
