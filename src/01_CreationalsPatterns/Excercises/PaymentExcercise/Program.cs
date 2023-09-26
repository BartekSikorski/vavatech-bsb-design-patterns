

using PaymentExcercise;


PaymentViewFactory paymentViewFactory = new PaymentViewFactory();


while (true)
{
    
    Console.Write("Podaj kwotę: ");

    decimal.TryParse(Console.ReadLine(), out decimal totalAmount);

    Console.Write("Wybierz rodzaj płatności: (G)otówka (K)karta płatnicza (P)rzelew: ");

    char paymentType = Console.ReadLine()[0];

    IPaymentView paymentView = paymentViewFactory.Create(paymentType);

    Payment payment = new Payment(totalAmount);
    paymentView.Show(payment);   

   // string icon = GetIcon(payment);

   // Console.WriteLine(icon);
}

//static string GetIcon(Payment payment)
//{
//    switch (payment.PaymentType)
//    {
//        case PaymentType.Cash: return "[100]";
//        case PaymentType.CreditCard: return "[abc]";
//        case PaymentType.BankTransfer: return "[-->]";

//        default: return string.Empty;
//    }
//}