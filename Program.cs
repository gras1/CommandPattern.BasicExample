using System;

namespace CommandPattern.BasicExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create receiver, command, and invoker
            var receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);
            var invoker = new Invoker();

            // Set and execute command
            invoker.SetCommand(command);
            invoker.ExecuteCommand();

            // Wait for user
            Console.ReadKey();
        }
    }
}
