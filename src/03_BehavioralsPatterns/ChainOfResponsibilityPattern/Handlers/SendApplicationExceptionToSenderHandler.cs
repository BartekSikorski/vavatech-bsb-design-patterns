using System;

namespace ChainOfResponsibilityPattern.Handlers
{
    partial class SendApplicationExceptionToSenderHandler : MessageHandler, IMessageHandler
    {
        public override void Handle(MessageContext context)
        {
            try
            {
                base.Handle(context);
            }
            catch(ApplicationException e)
            {
                Console.WriteLine($"Send email {e.Message} to {context.Request.From}");
            }
        }
    }
}
