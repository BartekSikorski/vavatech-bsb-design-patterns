using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentExcercise
{
    public class PaymentViewFactory
    {
        private Dictionary<char, Type> types = new Dictionary<char, Type>();

        public PaymentViewFactory()
        {
            types.Add('G', typeof(CashPaymentView));
            types.Add('K', typeof(CreditCardPaymentView));
            types.Add('P', typeof(BankTransferPaymentView));
            types.Add('B', typeof(BlikPaymentView));
        }

        public IPaymentView Create(char symbol)
        {
            Type type = types[symbol];

            IPaymentView paymentView = (IPaymentView) Activator.CreateInstance(type);

            return paymentView;
        }
    }
}
