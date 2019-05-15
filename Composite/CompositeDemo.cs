﻿using System;
using System.Collections.Generic;

namespace Composite
{
    class CompositeDemo
    {
        public void Composite()
        {
            int goldForKill = 1023;
            Console.WriteLine($"We gained {goldForKill} gold!");

            var joe = new Person {Name = "Joe"};
            var jake = new Person {Name = "Jake"};
            var emily = new Person {Name = "Emily"};
            var sophia = new Person {Name = "Sophia"};
            var brian = new Person {Name = "Brian"};
            var developers = new Group {Name = "Developers", Members = {joe, jake, emily}};

            var individuals = new List<Person> {sophia, brian};
            var groups = new List<Group> {developers};

            var totalToSplitBy = individuals.Count + groups.Count;

            var amountForEach = goldForKill / totalToSplitBy;
            var leftOver = goldForKill % totalToSplitBy;

            foreach (var individual in individuals)
            {
                individual.Gold += amountForEach + leftOver;
                leftOver = 0;
                individual.Stats();
            }

            foreach (var group in groups)
            {
                var amountForEachGroupMember = amountForEach / group.Members.Count;
                var leftOverForGroup = amountForEachGroupMember % group.Members.Count;
                foreach (var member in group.Members)
                {
                    member.Gold += amountForEach + leftOver;
                    leftOver = 0;
                    member.Stats();
                }
            }
        }
    }
}
