

using PaymentExcercise;

// TODO: Dodaj płatność BLIK zgodnie z zasadą otwarte-zamknięte

while (true)
{
    Console.Write("Podaj kwotę: ");

    decimal.TryParse(Console.ReadLine(), out decimal totalAmount);

    Console.Write("Wybierz rodzaj płatności: (G)otówka (K)karta płatnicza (P)rzelew: ");

    var paymentType = Enum.Parse<PaymentType>(Console.ReadLine());

    Payment payment = new Payment(paymentType, totalAmount);

    if (payment.PaymentType == PaymentType.Cash)
    {
        CashPaymentView cashPaymentView = new CashPaymentView();
        cashPaymentView.Show(payment);
    }
    else
    if (payment.PaymentType == PaymentType.CreditCard)
    {
        CreditCardPaymentView creditCardView = new CreditCardPaymentView();
        creditCardView.Show(payment);
    }
    else
    if (payment.PaymentType == PaymentType.BankTransfer)
    {
        BankTransferPaymentView bankTransferPaymentView = new BankTransferPaymentView();
        bankTransferPaymentView.Show(payment);
    }

    string icon = GetIcon(payment);

    Console.WriteLine(icon);
}

static string GetIcon(Payment payment)
{
    switch (payment.PaymentType)
    {
        case PaymentType.Cash: return "[100]";
        case PaymentType.CreditCard: return "[abc]";
        case PaymentType.BankTransfer: return "[-->]";

        default: return string.Empty;
    }
}