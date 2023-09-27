namespace StrategyPattern
{
    // Abstract Strategy
    public interface IDiscountCalculatorStrategy
    {
        bool CanDiscount(Order order);
        decimal Discount(Order order);
        decimal NoDiscount { get; }
    }
}
