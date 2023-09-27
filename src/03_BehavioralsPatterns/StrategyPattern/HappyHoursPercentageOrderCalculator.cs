using System;

namespace StrategyPattern
{
   
   


    // Abstract Strategy
    public interface IDiscountCalculatorStrategy
    {
        bool CanDiscount(Order order);
        decimal Discount(Order order);
        decimal NoDiscount { get; }
    }

    // Concrete Strategy A
    // Happy Hours - 10% upustu w godzinach od 9 do 15
    public class HappyHoursPercentageDiscountCalculatorStrategy : IDiscountCalculatorStrategy
    {
        private readonly TimeSpan from;
        private readonly TimeSpan to;

        private readonly decimal percentage;

        public HappyHoursPercentageDiscountCalculatorStrategy(TimeSpan from, TimeSpan to, decimal percentage)
        {
            this.from = from;
            this.to = to;
            this.percentage = percentage;
        }

        public decimal NoDiscount => decimal.Zero;

        public bool CanDiscount(Order order)
        {
            return order.OrderDate.TimeOfDay >= from && order.OrderDate.TimeOfDay <= to;
        }

        public decimal Discount(Order order)
        {
            return order.Amount * percentage;
        }
    }

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
