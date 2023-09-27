namespace StrategyPattern
{
    public class OrderCalculator
    {
        private readonly IDiscountCalculatorStrategy discountCalculatorStrategy;

        public OrderCalculator(IDiscountCalculatorStrategy discountCalculatorStrategy)
        {
            this.discountCalculatorStrategy = discountCalculatorStrategy;
        }

        public decimal CalculateDiscount(Order order)
        {
            if (discountCalculatorStrategy.CanDiscount(order))                      // CanDiscount (Predykat)
            {
                return discountCalculatorStrategy.Discount(order);                  // Discount
            }
            else
                return discountCalculatorStrategy.NoDiscount;                       // NoDiscount
        }
    }
}
