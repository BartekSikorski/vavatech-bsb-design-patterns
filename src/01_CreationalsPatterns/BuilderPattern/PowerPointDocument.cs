using System;

namespace BuilderPattern
{
    public class PowerPointDocument
    {
        public void Add(string content)
        {
            Console.WriteLine($"Add {content} to the powerpoint");
        }
    }
}
