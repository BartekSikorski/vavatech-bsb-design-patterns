namespace BridgePattern.CopySourceTarget
{
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
}
