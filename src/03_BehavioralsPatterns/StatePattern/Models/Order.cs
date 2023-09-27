using Stateless;
using System;
using System.Diagnostics.Tracing;
using System.Threading.Channels;

namespace StatePattern
{
    // Install-Package Stateless
    public class Order
    {
        private readonly StateMachine<OrderStatus, OrderTrigger> machine;

        public Order(OrderStatus initialState = OrderStatus.Placement)
        {
            Id = Guid.NewGuid();
            OrderDate = DateTime.Now;

            machine = new StateMachine<OrderStatus, OrderTrigger>(OrderStatus.Placement);

            machine.Configure(OrderStatus.Placement)
                .OnEntry(() => Console.WriteLine("Send welcome email"))
                .OnExit(() => Console.WriteLine("Send in progress email"))
                .PermitIf(OrderTrigger.Confirm, OrderStatus.Picking, () => IsPaid)
                .Permit(OrderTrigger.Cancel, OrderStatus.Canceled);

            machine.Configure(OrderStatus.Picking)
                .OnEntry(() => Console.WriteLine("kompletacja"))
                .Permit(OrderTrigger.Confirm, OrderStatus.Shipping);

            machine.Configure(OrderStatus.Shipping)
                .Permit(OrderTrigger.Confirm, OrderStatus.Delivered);

            machine.Configure(OrderStatus.Delivered)
                .Permit(OrderTrigger.Confirm, OrderStatus.Completed)
                .Permit(OrderTrigger.Cancel, OrderStatus.Canceled);

            //   machine.OnTransitioned()           

        }

        public string Graph => Stateless.Graph.UmlDotGraph.Format(machine.GetInfo());

        public Guid Id { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status => machine.State;
        public bool IsPaid { get; private set; }

        public void Paid()
        {
            IsPaid = true;
        }

        public void Confirm() => machine.Fire(OrderTrigger.Confirm);

        public void Cancel() => machine.Equals(OrderTrigger.Cancel);

        public override string ToString() => $"Order {Id} created on {OrderDate}{Environment.NewLine}";

        public virtual bool CanConfirm => Status == OrderStatus.Placement || Status == OrderStatus.Shipping || Status == OrderStatus.Delivered;
        public virtual bool CanCancel => Status == OrderStatus.Placement || Status == OrderStatus.Delivered;
    }

    public enum OrderStatus
    {
        // The customer places an order on the company's website
        Placement,
        // The items from the order are picked from the inventory
        Picking,
        // The package is handed over to the shipping carrier or courier for delivery to the customer.      
        Shipping,
        // The package has been successfully delivered to the customer's specified address.
        Delivered,
        // The order has been successfully delivered, and the transaction is considered complete.
        Completed,
        // The customer canceled order
        Canceled

    }

    public enum OrderTrigger
    {
        Confirm,
        Cancel
    }

}
