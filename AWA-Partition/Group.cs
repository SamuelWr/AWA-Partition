using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWA_Partition
{
    public class Group
    {
        List<Person> members = new List<Person>();
        public void Add(Person p)
        {
            members.Add(p);
            members.Sort();
        }
        public override string ToString()
        {
            string s = "";
            string divider = ", ";
            bool usedivider = false;
            foreach (var p in members)
            {
                if (usedivider)
                    s += divider;
                usedivider = true;
                s += p.Name;

            }
            return s;
        }
    }
}
