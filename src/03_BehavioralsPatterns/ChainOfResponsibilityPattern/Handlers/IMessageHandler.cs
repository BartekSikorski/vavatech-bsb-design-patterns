using ChainOfResponsibilityPattern.Models;
using System;

namespace ChainOfResponsibilityPattern.Handlers
{
    public interface IMessageHandler
    {
        void Handle(MessageContext context);
        void SetNext(IMessageHandler next);
    }


    public class Context<TRequest, TResponse>
        where TResponse : new()
    {
        public TRequest Request { get; }
        public TResponse Response { get; set; } = new TResponse();
        public Context(TRequest request) => Request = request;
    }

    public class MessageContext : Context<Message, MessageResponse>
    {
        public MessageContext(Message request) : base(request)
        {
        }
    }

    public class MessageResponse
    {
        public string TaxNumber { get; set; }
        public string CustomerName { get; set; }
    }

}
