using System.Collections.Generic;
using System.Linq;

namespace BridgePattern.CopySourceTarget
{
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
}
