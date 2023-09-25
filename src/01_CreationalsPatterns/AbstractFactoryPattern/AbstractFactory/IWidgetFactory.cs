namespace AbstractFactoryPattern.AbstractFactory
{
    // Abstract Factory
    public interface IWidgetFactory
    {
        ITextBox CreateTextBox();
        IButton CreateButton();
    }



}
