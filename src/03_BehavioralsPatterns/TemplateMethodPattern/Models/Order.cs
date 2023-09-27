using System;
using System.Collections;
using System.Collections.Generic;

namespace TemplateMethodPattern
{
    public class Order
    {
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }
        public decimal Amount { get; set; }

        public ICollection<OrderDetail> Details { get; set; }

        public Order(DateTime orderDate, Customer customer, decimal amount)
        {
            OrderDate = orderDate;
            Customer = customer;
            Amount = amount;

            this.Details = new List<OrderDetail>();
        }
    }


    public class OrderDetail
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }


    public class Product
    {
        public string Name { get; set; }
        public bool IsDiscounted => Discount.HasValue;
        public decimal? Discount { get; set; }
    }

}
