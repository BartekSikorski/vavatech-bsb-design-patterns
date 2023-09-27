using ChainOfResponsibilityPattern.Models;

namespace ChainOfResponsibilityPattern.Handlers
{
    public interface IMessageHandler
    {
        void Handle(Message message);
        void SetNext(IMessageHandler next);
    }


}
