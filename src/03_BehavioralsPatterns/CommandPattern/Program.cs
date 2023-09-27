using System;
using System.Collections.Generic;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Command Pattern!");

            Message message = new Message("555000123", "555888000", "Hello World!");

            ICommand command1 = new PrintMessageCommand(message, 5);
            ICommand command2 = new PrintMessageCommand(message, 3);
            ICommand command3 = new SendMessageCommand(message);
            ICommand command4 = new PrintMessageCommand(message);

            Queue<ICommand> commands = new Queue<ICommand>();
            commands.Enqueue(command1);
            commands.Enqueue(command2);
            commands.Enqueue(command3);
            commands.Enqueue(command4);

            // ...

            while(commands.Count > 0)
            {
                ICommand command = commands.Dequeue();
                command.Execute();
            }

        }
    }

}
