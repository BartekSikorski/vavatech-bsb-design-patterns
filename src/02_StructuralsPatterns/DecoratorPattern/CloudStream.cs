using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{

    public class CloudStream : Stream
    {
        public void Write(string data)
        {
            Console.WriteLine($"Storing {data}");
        }
    }

}
