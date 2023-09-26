using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class RadioAdapterFactory
    {
        public static ITextRadioAdapter Create(string radioType)
        {
            switch(radioType)
            {
                case "Motorola": return new MotorolaRadioAdapter("1234");
                case "Hytera": return new HyteraRadioAdapter();

                default:
                    throw new NotSupportedException();
            }
        }
    }
}
