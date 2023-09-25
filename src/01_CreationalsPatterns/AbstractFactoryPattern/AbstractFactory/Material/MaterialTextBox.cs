using System;

namespace AbstractFactoryPattern.AbstractFactory.Material
{
    // Concrete Component B
    public class MaterialTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Material TextBox");
        }
    }
}
