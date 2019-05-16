using System;

namespace Command.Commands
{
    public class UpdateQuantityCommand : ICommand, ICommandFactory
    {
        public int NewQuantity { get; set; }

        public void Execute()
        {
            Console.WriteLine($"Updated quantity to {NewQuantity}");
        }

        public string CommandName => "UpdateQuantity";
        public string Description => "Update Quantity!!";
        public ICommand MakeCommand(string[] arguments)
        {
            return new UpdateQuantityCommand { NewQuantity = int.Parse(arguments[1])};
        }
    }
}
