using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Handlers
{

    public class ConsoleLoggerExceptionMessageHandler : MessageHandler, IMessageHandler
    {
        public override void Handle(MessageContext context)
        {
            try
            {
                base.Handle(context);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

                throw;
            }
        }
    }
}
