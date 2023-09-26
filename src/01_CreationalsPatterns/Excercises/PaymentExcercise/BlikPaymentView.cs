namespace PaymentExcercise;

public class BlikPaymentView : IPaymentView
{
    public void Show(Payment payment)
    {
        Console.WriteLine($"Blik {payment.TotalAmount}");
    }
}
