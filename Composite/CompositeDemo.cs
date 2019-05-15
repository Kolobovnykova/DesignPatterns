using System;
using System.Collections.Generic;

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
            var developers = new Group {Name = "Developers", Members = {joe, jake, emily}};

            var parties = new List<IParty> {developers, sophia, brian};

            var totalToSplitBy = parties.Count;

            var amountForEach = goldForKill / totalToSplitBy;
            var leftOver = goldForKill % totalToSplitBy;

            foreach (var partyMember in parties)
            {
                partyMember.Gold += amountForEach + leftOver;
                leftOver = 0;
                partyMember.Stats();
            }
        }
    }
}
