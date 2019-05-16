using System;
using System.Collections.Generic;
using Command.Commands;

namespace Command
{
    public static class CommandDemo
    {
        public static void RunCommand(string[] args)
        {
            var availableCommads = GetAvailableCommands();
            
            if (args.Length == 0)
            {
                PrintUsage(availableCommads);
                return;
            }

            var parser = new CommandParser(availableCommads);
            var command = parser.ParseCommand(args);

            if (command != null)
            {
                command.Execute();
            }
        }

        private static IEnumerable<ICommandFactory> GetAvailableCommands()
        {
            return new ICommandFactory[]
                {
                    new ShipOrderCommand(),
                    new UpdateQuantityCommand(),
                    new CreateOrderCommand()
                };
        }

        private static void PrintUsage(IEnumerable<ICommandFactory> availableCommands)
        {
            Console.WriteLine("Available commands:");
            foreach (var command in availableCommands)
            {
                Console.WriteLine($" {command.Description}");
            }
        }

        // Trying to run without Command Pattern
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
