using System;

namespace PaymentExcercise
{
    public class CreditCardPaymentView :IPaymentView
    {
        public void Show(Payment payment)
        {
            Console.WriteLine($"Do zapłaty {payment.TotalAmount}");

            Console.WriteLine($"Nawiązywanie połączenia z bankiem...");

            Console.WriteLine("Transakcja zautoryzowana");
        }
    }
}
