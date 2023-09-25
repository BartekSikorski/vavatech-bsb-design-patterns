using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    // Factory
    public class VisitCalculatorFactory
    {
        public static IVisitCalculator Create(string visitType)
        {
            switch (visitType)
            {
                case "N":
                    return new NfzVisitCalculator();
                case "P":
                    return new PrivateVisitCalculator(100);
                case "F":
                    return new CompanyVisitCalculator(100, 0.9m);                
                default:
                    throw new NotSupportedException($"Typ wizyty {visitType} nie jest obsługiwany.");
            }
        }
    }
}
