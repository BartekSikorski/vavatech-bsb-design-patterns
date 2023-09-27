using StrategyPattern.CanDiscountStrategies;
using StrategyPattern.DiscountStrategies;

namespace StrategyPattern
{
    public class OrderCalculator
    {
        private readonly ICanDiscountStrategy canDiscountStrategy;
        private readonly IDiscountStrategy discountStrategy;

        public OrderCalculator(ICanDiscountStrategy canDiscountStrategy, IDiscountStrategy discountStrategy)
        {
            this.canDiscountStrategy = canDiscountStrategy;
            this.discountStrategy = discountStrategy;
        }

        public decimal CalculateDiscount(Order order)
        {
            if (canDiscountStrategy.CanDiscount(order))                      // CanDiscount (Predykat)
            {
                return discountStrategy.Discount(order);                  // Discount
            }
            else
                return discountStrategy.NoDiscount;                       // NoDiscount
        }
    }

   


}
