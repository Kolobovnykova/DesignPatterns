using System;

namespace Composite
{
    public static class CompositeDemo
    {
        public static void Composite()
        {
            int goldForKill = 1023;
            Console.WriteLine($"We gained {goldForKill} gold!");

            var joe = new Person {Name = "Joe"};
            var jake = new Person {Name = "Jake"};
            var emily = new Person {Name = "Emily"};
            var sophia = new Person {Name = "Sophia"};
            var brian = new Person {Name = "Brian"};
            var oldBob = new Person {Name = "Old Bob"};
            var newBob = new Person {Name = "New Bob"};
            var bobs = new Group {Members = {newBob, oldBob}};
            var developers = new Group {Name = "Developers", Members = {joe, jake, emily, bobs}};

            var parties = new Group {Members = {developers, sophia, brian}};

            parties.Gold += goldForKill;
            parties.Stats();
        }
    }
}
