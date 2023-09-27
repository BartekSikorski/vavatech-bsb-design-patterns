using ChainOfResponsibilityPattern.Models;
using System;

namespace ChainOfResponsibilityPattern.Handlers
{
    // Concrete Handler B
    public class ValidateTitleContainsHandler : MessageHandler, IMessageHandler
    {
        private readonly string content;

        public ValidateTitleContainsHandler(string content)
        {
            this.content = content;
        }

        public override void Handle(Message message)
        {
            ValidateTitleContains(message, content);

            base.Handle(message);
        }

        private static void ValidateTitleContains(Message message, string content)
        {
            if (!message.Title.Contains(content))
            {
                throw new Exception();
            }
        }
    }


}
