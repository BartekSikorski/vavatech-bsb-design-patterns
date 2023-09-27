namespace StrategyPattern.CanDiscountStrategies
{
    public interface ICanDiscountStrategy
    {
        bool CanDiscount(Order order);
    }
}
