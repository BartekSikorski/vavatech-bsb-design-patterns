namespace StrategyPattern.DiscountStrategies
{
    public class PercentageDiscountStrategy : IDiscountStrategy
    {
        private readonly decimal percentage;
        public PercentageDiscountStrategy(decimal percentage) => this.percentage = percentage;
        public decimal NoDiscount => decimal.Zero;
        public decimal Discount(Order order) => order.Amount * percentage;
    }
}
