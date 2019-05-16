using System;

namespace Command.Commands
{
    public class CreateOrderCommand : ICommand, ICommandFactory
    {
        public void Execute()
        {
            Console.WriteLine("Created new order!");
        }

        public string CommandName => "CreateOrder";
        public string Description => "Create Order!!!";
        public ICommand MakeCommand(string[] arguments)
        {
            return new CreateOrderCommand();
        }
    }
}
