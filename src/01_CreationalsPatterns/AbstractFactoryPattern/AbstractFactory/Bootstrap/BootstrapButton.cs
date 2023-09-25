using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AbstractFactory.Bootstrap
{
    // Concrete Component A
    public class BootstrapButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Boostrap Button");
        }
    }
}
