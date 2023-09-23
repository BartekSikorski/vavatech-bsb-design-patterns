using System;

namespace PaymentExcercise;

public class CashPaymentView
{
    public void Show(Payment payment)
    {
        Console.WriteLine($"Do zapłaty {payment.TotalAmount}");
        Console.Write("Otrzymano: ");
        decimal.TryParse(Console.ReadLine(), out decimal receivedAmount);

        decimal restAmount = payment.TotalAmount - receivedAmount;

        if (restAmount > 0)
        {
            Console.WriteLine($"Reszta {restAmount}");
        }
    }
}
