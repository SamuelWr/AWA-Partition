using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partitioner
{
    public class Group
    {
        List<string> members = new List<string>();
        public void Add(string name)
        {
            members.Add(name);
            members.Sort();
        }
        public override string ToString()
        {
            string s = "";
            string divider = ", ";
            bool usedivider = false;
            foreach (var member in members)
            {
                if (usedivider)
                    s += divider;
                usedivider = true;
                s += member;

            }
            return s;
        }
    }
}
