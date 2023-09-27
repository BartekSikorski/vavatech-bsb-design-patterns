using System.Linq;

namespace TemplateMethodPattern
{
    public class DiscountedProductOrderCalculator : OrderCalculator
    {
        public override bool CanDiscount(Order order)
        {
            return order.Details.Any(p => p.Product.IsDiscounted);
        }

        public override decimal Discount(Order order)
        {
            return order.Details.Select(p => p.Product).Sum(p => p.Discount.Value);
        }
    }

}
