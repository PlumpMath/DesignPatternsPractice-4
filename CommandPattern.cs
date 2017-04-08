// Command Design Pattern Example in C#
using System;
namespace Hello
{
    //Command
    public abstract class Command
    {
        protected Receiver receiver;
        public Command(){}
        public abstract void Execute();
    }
    //ConcreteCommand
    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver)
        {
            this.receiver = receiver;
        }
        public override void Execute()
        {
            receiver.Action();
        }

    }
    //Receiver
    public class Receiver
    {
        public void Action()
        {
            Console.WriteLine("Hello, I received your command!");
        }
    }
    //Invoker
    public class Invoker
    {
        private Command command;
        public void setCommand(Command command)
        {
            this.command = command;
        }
        public void ExecuteCommand()
        {
            command.Execute();
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //Create receiver, command, and Invoker
            Receiver receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();
            invoker.setCommand(command);
            invoker.ExecuteCommand();
        }
    }
}
