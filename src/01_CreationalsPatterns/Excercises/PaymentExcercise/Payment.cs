using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentExcercise
{
    public class Payment
    {
        public DateTime PaymentDate { get; set; }        
        public decimal TotalAmount { get; set; }

        public Payment(DateTime paymentDate, decimal totalAmount)
        {
            PaymentDate = paymentDate;            
            TotalAmount = totalAmount;
        }

        public Payment(decimal totalAmount)
            :this(DateTime.Now, totalAmount)
        { }

    }

    public enum PaymentType
    {
        Cash,
        CreditCard,
        BankTransfer
    }
}
