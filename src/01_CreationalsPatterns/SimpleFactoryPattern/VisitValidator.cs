namespace SimpleFactoryPattern
{
    public class VisitValidator : IValidator<Visit>
    {
        public bool Validate(Visit value)
        {
            Validate(value.Duration);

            return true;
        }

        private static void Validate(TimeSpan duration)
        {
            if (duration < TimeSpan.Zero)
            {
                throw new ArgumentOutOfRangeException(nameof(duration));
            }
        }
    }

}
