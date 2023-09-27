using StrategyPattern.CanDiscountStrategies;
using StrategyPattern.DiscountStrategies;

namespace StrategyPattern
{
    // Abstract Strategy
    public interface IDiscountCalculatorStrategy : ICanDiscountStrategy, IDiscountStrategy
    {
              
    }
}
