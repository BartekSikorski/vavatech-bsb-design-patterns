using ChainOfResponsibilityPattern.Models;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Handlers
{

    // Abstract Handler
    public abstract class MessageHandler : IMessageHandler
    {
        protected IMessageHandler next;

        public void SetNext(IMessageHandler next)
        {
            this.next = next;
        }

        public virtual void Handle(Message message)
        {
            if (next != null)
                next.Handle(message);
        }
    }


}
