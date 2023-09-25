namespace SimpleFactoryPattern
{
    public interface IValidator<T>
    {
        bool Validate(T value);
    }

}
