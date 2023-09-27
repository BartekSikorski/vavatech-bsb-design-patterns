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

        public override void Handle(MessageContext context)
        {
            ValidateTitleContains(context.Request, content);

            base.Handle(context);
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
