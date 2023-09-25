﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace PrototypePattern
{
    public class Bill
    {
        public string Number { get; set; }
        public DateTime CreateDate { get; set; }
        public decimal TotalAmount { get; set; }
    }

    public class Invoice : ICloneable
    {
        public Invoice(string number, DateTime createDate, Customer customer)
        {
            Number = number;
            CreateDate = createDate;
            Customer = customer;
            PaymentStatus = PaymentStatus.Awaiting;
        }

        public string Number { get; set; }
        public DateTime CreateDate { get; set; }
        public Customer Customer { get; set; }

        public PaymentStatus PaymentStatus { get; private set; }
         
        public decimal TotalAmount => Details.Sum(d => d.Quantity * d.Amount);

        public IList<InvoiceDetail> Details { get; set; } = new List<InvoiceDetail>();

        public void Paid(decimal amount)
        {
            if (amount >= TotalAmount)
            {                
                PaymentStatus = PaymentStatus.Paid;
            }
        }

        public override string ToString()
        {
            return $"Invoice No {Number} {TotalAmount:C2} {Customer.FullName}";
        }

        private Invoice Copy()
        {
            var invoice = new Invoice(this.Number, this.CreateDate, this.Customer);

            foreach (var detail in this.Details)
            {
                invoice.Details.Add((InvoiceDetail)detail.Clone());
            }

            invoice.PaymentStatus = this.PaymentStatus;

            return invoice;
        }

        public object Clone()
        {
            return Copy();
        }
    }

    public enum PaymentStatus
    {
        Awaiting,
        Paid,        
    }

   


}
