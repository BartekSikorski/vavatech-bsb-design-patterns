using ChainOfResponsibilityPattern.Models;
using System;
using System.Linq;

namespace ChainOfResponsibilityPattern.Handlers
{
    // Concrete Handler A
    public class ValidateFromWhiteListHandler : MessageHandler, IMessageHandler
    {
        private readonly string[] whiteList;

        public ValidateFromWhiteListHandler(string[] whiteList)
        {
            this.whiteList = whiteList;
        }

        public override void Handle(Message message)
        {
            if (IsFromWhiteList(message))
            {
                base.Handle(message);
            }
            else
            {
                throw new Exception();
            }
        }

        private bool IsFromWhiteList(Message message) => whiteList.Contains(message.From);
    }


}
