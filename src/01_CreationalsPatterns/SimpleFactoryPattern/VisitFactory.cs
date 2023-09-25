using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    // Factory
    public class VisitFactory
    {
        public static Visit Create(string visitType, TimeSpan duration)
        {
            switch (visitType)
            {
                case "N":
                    return new NfzVisit(duration, 0);
                case "P":
                    return new PrivateVisit(duration, 100);
                case "F":
                    return new CompanyVisit(duration, 100, 0.9m);
                case "T":
                    return new TeleVisit(duration, 100);
                default:
                    throw new NotSupportedException($"Typ wizyty {visitType} nie jest obsługiwany.");
            }
        }
    }
}
