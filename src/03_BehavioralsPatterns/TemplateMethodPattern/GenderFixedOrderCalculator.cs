namespace TemplateMethodPattern
{
    public class GenderFixedOrderCalculator
    {
        private readonly Gender gender;

        private readonly decimal amount;

        public GenderFixedOrderCalculator(Gender gender, decimal amount)
        {
            this.gender = gender;
            this.amount = amount;
        }

        public decimal CalculateDiscount(Order order)
        {
            if (order.Customer.Gender == gender)              // Warunek (Predykat)
            {
                return amount;             // Upust (Discount)
            }
            else
                return 0;                                     // Brak upustu (NoDiscount)
        }
    }
}
