using System;

namespace Composite
{
    class Person
    {
        public string Name { get; set; }
        public int Gold { get; set; }

        public void Stats()
        {
            Console.WriteLine($"{Name} has {Gold} gold");
        }
    }
}
