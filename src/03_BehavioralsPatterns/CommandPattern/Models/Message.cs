using System;

namespace CommandPattern
{
    public class SendMessageCommand : ICommand
    {
        private readonly Message message;

        public SendMessageCommand(Message message)
        {
            this.message = message;
        }

        public bool CanExecute()
        {
            return CanSend();
        }

        public void Execute()
        {
            Send();
        }

        private bool CanSend()
        {
            return !(string.IsNullOrEmpty(message.From) || string.IsNullOrEmpty(message.To) || string.IsNullOrEmpty(message.Content));
        }

        private void Send()
        {
            Console.WriteLine($"Send message from <{message.From}> to <{message.To}> {message.Content}");
        }
    }

    public class PrintMessageCommand : ICommand
    {
        private readonly Message message;
        private readonly byte copies;

        public PrintMessageCommand(Message message, byte copies = 1)
        {
            this.message = message;
            this.copies = copies;
        }

        public bool CanExecute()
        {
            return CanPrint();
        }

        private bool CanPrint()
        {
            return string.IsNullOrEmpty(message.Content);
        }

        public void Execute()
        {
            Print(copies);
        }

        private void Print(byte copies)
        {
            for (int i = 0; i < copies; i++)
            {
                Console.WriteLine($"Print message from <{message.From}> to <{message.To} >  {message.Content}");
            }
        }
    }

    public class Message
    {
        public Message(string from, string to, string content)
        {
            From = from;
            To = to;
            Content = content;
        }

        public string From { get; set; }
        public string To { get; set; }
        public string Content { get; set; }
    }
}
