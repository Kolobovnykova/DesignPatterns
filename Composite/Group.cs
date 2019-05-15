using System.Collections.Generic;

namespace Composite
{
    class Group
    {
        public string Name { get; set; }
        public List<Person> Members { get; set; }

        public Group()
        {
            Members = new List<Person>();
        }
    }
}
