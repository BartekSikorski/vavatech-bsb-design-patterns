namespace StrategyPattern.CanDiscountStrategies
{
    // Gender - 20% upustu dla kobiet
    public class GenderCanDiscountStrategy : ICanDiscountStrategy
    {
        private readonly Gender gender;
        public GenderCanDiscountStrategy(Gender gender) => this.gender = gender;
        public bool CanDiscount(Order order) => order.Customer.Gender == gender;
    }

    // TODO: Dodaj Happy Hours 9-17 tylko dla kobiet - 20% upustu
    // hint: zastosuj lancuch odpowiedzialnosci
}
