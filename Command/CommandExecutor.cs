using System;

namespace Command
{
    public class CommandExecutor
    {
        internal void ExecuteCommand(string[] args)
        {
            switch (args[0])
            {
                case "UpdateQuantity":
                    UpdateQuantity(int.Parse(args[1]));
                    break;
                case "CreateOrder":
                    CreateOrder();
                    break;
                case "ShipOrder":
                    ShipOrder();
                    break;
                default:
                    Console.WriteLine("Unrecognized command");
                    break;
            }
        }

        private void ShipOrder()
        {
            Console.WriteLine("Order shipped!");
        }

        private void CreateOrder()
        {
            Console.WriteLine("Created Order");
        }

        private void UpdateQuantity(int newQuantity)
        {
            Console.WriteLine($"Updated quantity to {newQuantity}");
        }
    }
}
