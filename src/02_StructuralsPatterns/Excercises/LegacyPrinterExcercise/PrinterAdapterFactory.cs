using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyPrinterExcercise
{
 
    // Adapter
    public class PrinterTypeMapper
    {
        public static PrinterType Map(bool legacy)
        {
            return legacy ? PrinterType.Legacy : PrinterType.Modern;
        }
    }

    public class PrinterAdapterFactory
    {                
        public static IPrinterAdapter Create(PrinterType printerType) 
        {
            switch(printerType)
            {
                case PrinterType.Legacy: return new LegacyPrinterAdapter();
                case PrinterType.Modern: return new Printer();

                default: throw new NotImplementedException();
            }
        
        }
    }
}
