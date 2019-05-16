using System;

namespace Command
{
    public static class CommandDemo
    {
        public static void Run(string[] args)
        {
            if (args.Length == 0)
            {
                PrintUsage();
                return;
            }

            var processor = new CommandExecutor();
            processor.ExecuteCommand(args);
        }

        private static void PrintUsage()
        {
            Console.WriteLine("Commads:");
            Console.WriteLine("     UpdateQuantity number");
            Console.WriteLine("     CreateOrder");
            Console.WriteLine("     ShipOrder");
        }
    }
}
