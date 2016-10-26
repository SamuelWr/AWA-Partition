using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWA_Partition
{
    public class Person : IComparable<Person>, IEquatable<Person>
    {
        public string Name;
        Dictionary<Person, int> collaborations;
        public int Collaborations(Person other)
        {
            if (collaborations.ContainsKey(other))
                return collaborations[other];
            else
                return 0;
        }
        public void Collaborate(Person other)
        {
            if (collaborations.ContainsKey(other))
                collaborations[other]++;
            else
                collaborations.Add(other, 1);
        }
        public int CompareTo(Person other)
        {
            return this.Name.CompareTo(other.Name);
        }

        public bool Equals(Person other)
        {
            return this.Name.Equals(other.Name);
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
