using System;

namespace BridgePattern.CopySourceTarget
{
    public class PdfCustomerTarget : ICustomerCommands
    {
        public void AddRange(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine($"Save to pdf {customer}");
            }
        }
    }
}
