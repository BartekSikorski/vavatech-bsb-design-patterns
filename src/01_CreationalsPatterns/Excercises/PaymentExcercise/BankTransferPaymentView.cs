using System;

namespace PaymentExcercise;

public class BankTransferPaymentView 
{
    public void Show(Payment payment)
    {
        Console.WriteLine($"Dane do przelewu {payment.TotalAmount}");
    }
}
