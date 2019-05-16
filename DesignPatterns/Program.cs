using System;
using Command;
using Composite;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CompositeDemo.Composite();
            var command = new string[]
            {
                "CreateOrder"
            };
            CommandDemo.RunCommand(command);

            Console.ReadKey();
        }
    }
}
