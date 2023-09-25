using System;

namespace AbstractFactoryPattern.AbstractFactory.Bootstrap
{
    // Concrete Component B
    public class BootstrapTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Bootstrap TextBox");
        }
    }
}
