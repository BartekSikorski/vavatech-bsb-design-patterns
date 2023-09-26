using System;

namespace PaymentExcercise;

public class BankTransferPaymentView  : IPaymentView
{
    public void Show(Payment payment)
    {
        Console.WriteLine($"Dane do przelewu {payment.TotalAmount}");
    }
}
