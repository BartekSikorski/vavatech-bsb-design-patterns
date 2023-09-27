namespace TemplateMethodPattern
{
    // Abstract
    public abstract class OrderCalculator
    {
        public abstract bool CanDiscount(Order order);
        public abstract decimal Discount(Order order);
        public virtual decimal NoDiscount
        {
            get
            {
                return decimal.Zero;
            }
        }

        public decimal CalculateDiscount(Order order)                   // Template Method
        {
            if (CanDiscount(order))                                     // Warunek (Predykat)
            {
                return Discount(order);                                 // Upust (Discount)
            }
            else
                return NoDiscount;                                      // Brak upustu (NoDiscount)
        }
    }

}
