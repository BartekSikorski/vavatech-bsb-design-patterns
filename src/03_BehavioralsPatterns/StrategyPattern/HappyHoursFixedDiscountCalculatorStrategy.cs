using System;

namespace StrategyPattern
{
    // Concrete Strategy A
    // Happy Hours - upust kwotowy w godzinach od 9 do 15
    public class HappyHoursFixedDiscountCalculatorStrategy : IDiscountCalculatorStrategy
    {
        private readonly TimeSpan from;
        private readonly TimeSpan to;

        private readonly decimal amount;

        public HappyHoursFixedDiscountCalculatorStrategy(TimeSpan from, TimeSpan to, decimal amount)
        {
            this.from = from;
            this.to = to;
            this.amount = amount;
        }

        public decimal NoDiscount => decimal.Zero;

        public bool CanDiscount(Order order)
        {
            return order.OrderDate.TimeOfDay >= from && order.OrderDate.TimeOfDay <= to;
        }

        public decimal Discount(Order order)
        {
            return amount;
        }
    }
}
