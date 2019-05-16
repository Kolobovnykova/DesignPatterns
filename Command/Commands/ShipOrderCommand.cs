using System;

namespace Command.Commands
{
    class ShipOrderCommand : ICommand, ICommandFactory
    {
        public void Execute()
        {
            Console.WriteLine("Shipping");
        }

        public string CommandName => "ShipOrder";

        public string Description => "Ship order!!";

        public ICommand MakeCommand(string[] arguments)
        {
            return new ShipOrderCommand();
        }
    }
}
