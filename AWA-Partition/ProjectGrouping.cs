using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWA_Partition
{
    class ProjectGrouping
    {
        public List<Group> Groups;

        public override string ToString()
        {
            string s = "";
            foreach (var item in Groups)
            {
                s += item.ToString();
            }
            return s;
        }
    }
}
