namespace StrategyPattern.CanDiscountStrategies
{
    // Gender - 20% upustu dla kobiet
    public class GenderCanDiscountStrategy : ICanDiscountStrategy
    {
        private readonly Gender gender;
        public GenderCanDiscountStrategy(Gender gender) => this.gender = gender;
        public bool CanDiscount(Order order) => order.Customer.Gender == gender;
    }
    
}
