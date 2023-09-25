using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    public class ConsoleColorFactory
    {
        public static ConsoleColor Create(decimal value)
        {
            switch (value)
            {
                case 0:
                    return ConsoleColor.Green;
                case >= 200:
                    return ConsoleColor.Red;
                default:
                    return ConsoleColor.White;
            }
        }                  
    }

}
