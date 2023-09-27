using ChainOfResponsibilityPattern.Models;
using System;
using System.Text.RegularExpressions;

namespace ChainOfResponsibilityPattern.Handlers
{
    // Concrete Handler C
    public class ExtractTaxNumberHandler : MessageHandler, IMessageHandler
    {
        public override void Handle(Message message)
        {
            var taxNumber = ExtractTaxNumber(message);

            base.Handle(message);
        }

        private static string ExtractTaxNumber(Message message)
        {
            string pattern = @"\b(\d{10}|\d{3}-\d{3}-\d{2}-\d{2})\b";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(message.Body);

            if (match.Success)
            {
                string taxNumber = match.Value;

                return taxNumber;
            }
            else
            {
                throw new FormatException();
            }
        }
    }


}
