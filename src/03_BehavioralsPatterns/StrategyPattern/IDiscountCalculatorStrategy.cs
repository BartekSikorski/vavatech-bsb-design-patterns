namespace StrategyPattern
{
    // Abstract Strategy
    public interface IDiscountCalculatorStrategy : ICanDiscountStrategy, IDiscountStrategy
    {
              
    }

    public interface ICanDiscountStrategy
    {
        bool CanDiscount(Order order);
    }

    public interface IDiscountStrategy
    {
        decimal Discount(Order order);
        decimal NoDiscount { get; }
    }
}
