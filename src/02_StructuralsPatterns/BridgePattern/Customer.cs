using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Customer
    {
    }

  

    public interface ICustomerService
    {
        Customer[] GetAll();
    }


    public interface ICustomerQuery
    {
        Customer[] GetAll();
    }

    public interface ICustomerCommands
    {
        void AddRange(Customer[] customers);
    }

    public class BridgeCustomer
    {
        private ICustomerQuery source;
        private ICustomerCommands target;

        public BridgeCustomer(ICustomerQuery source, ICustomerCommands target)
        {
            this.source = source;
            this.target = target;
        }

        public void Copy()
        {
            target.AddRange(source.GetAll());
        }
    }

    public class FakeCustomerService : ICustomerQuery
    {
        private readonly Dictionary<int, Customer> _customers = new Dictionary<int, Customer>();

        public FakeCustomerService()
        {
            _customers.Add(1, new Customer());
            _customers.Add(2, new Customer());
            _customers.Add(3, new Customer());

        }
        public Customer[] GetAll()
        {
            return _customers.Values.ToArray();
        }
    }

    public class PdfCustomerTarget : ICustomerCommands
    {
        public void AddRange(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine( $"Save to pdf {customer}");
            }
        }
    }

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
