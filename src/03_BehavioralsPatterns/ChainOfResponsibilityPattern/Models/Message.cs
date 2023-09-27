using ChainOfResponsibilityPattern.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Models
{
    public class Message
    {
        public string From { get; set; }
        public string Title { get; set; }   
        public string Body { get; set; }
    }

    public class MessageProcessor
    {
        private readonly IMessageHandler startMessageHandler;

        public MessageProcessor(IMessageHandler messageHandler) => this.startMessageHandler = messageHandler;

        public string Process(Message message)
        {
            startMessageHandler.Handle(message);

            throw new NotImplementedException();            

        }
    }
}
