using System;

namespace BridgePattern.CopySourceTarget
{
    public class CsvCustomerTarget : ICustomerQuery, ICustomerCommands
    {
        public void AddRange(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine($"Save to csv {customer}");
            }
        }

        public Customer[] GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
