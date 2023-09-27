namespace StrategyPattern.DiscountStrategies
{
    public class FixedDiscountStrategy : IDiscountStrategy
    {
        private readonly decimal amount;
        public FixedDiscountStrategy(decimal amount) => this.amount = amount;
        public decimal NoDiscount => decimal.Zero;
        public decimal Discount(Order order) => amount;
    }


}
