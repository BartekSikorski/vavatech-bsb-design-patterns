using System;

namespace TemplateMethodPattern
{
    public class HappyHoursFixedOrderCalculator
    {
        private readonly TimeSpan from;
        private readonly TimeSpan to;

        private readonly decimal amount;

        public HappyHoursFixedOrderCalculator(TimeSpan from, TimeSpan to, decimal amount)
        {
            this.from = from;
            this.to = to;
            this.amount = amount;
        }

        public decimal CalculateDiscount(Order order)
        {
            if (order.OrderDate.TimeOfDay >= from && order.OrderDate.TimeOfDay < to)
            {
                return amount;
            }
            else
                return 0;
        }
    }

}
