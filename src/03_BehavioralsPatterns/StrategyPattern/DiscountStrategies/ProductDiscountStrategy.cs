using System.Linq;

namespace StrategyPattern.DiscountStrategies
{
    public class ProductDiscountStrategy : IDiscountStrategy
    {
        public decimal NoDiscount => decimal.Zero;

        public decimal Discount(Order order) => order.Details.Select(p => p.Product).Sum(p => p.Discount.Value);
    }
}
