namespace StrategyPattern.DiscountStrategies
{
    public interface IDiscountStrategy
    {
        decimal Discount(Order order);
        decimal NoDiscount { get; }
    }
}
