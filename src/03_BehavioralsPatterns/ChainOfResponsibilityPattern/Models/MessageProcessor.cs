using ChainOfResponsibilityPattern.Handlers;
using System;

namespace ChainOfResponsibilityPattern.Models
{
    public class MessageProcessor
    {
        private readonly IMessageHandler startMessageHandler;

        public MessageProcessor(IMessageHandler messageHandler) => this.startMessageHandler = messageHandler;

        public string Process(Message message)
        {
            MessageContext context = new MessageContext(message);

            startMessageHandler.Handle(context);

            return context.Response.TaxNumber;

        }
    }
}
