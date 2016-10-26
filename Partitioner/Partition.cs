using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partitioner
{
    public static class Partition
    {
        private static List<Person> Students;
        static Partition()
        {
            Students = new List<Person>
            {
                new Person() { Name="Pauline"},
                new Person() { Name="Paula"},
                new Person() { Name="Oliver"},
                new Person() { Name="Julia"},
                new Person() { Name="Linnéa"},
                new Person() { Name="Johan A"},
                new Person() { Name="Caroline"},
                new Person() { Name="Elias"},
                new Person() { Name="Viktor"},
                new Person() { Name="Andreas"},
                new Person() { Name="Johanna"},
                new Person() { Name="Bernhard"},
                new Person() { Name="Dino"},
                new Person() { Name="Tim P"},
                new Person() { Name="Karin"},
                new Person() { Name="Josefine"},
                new Person() { Name="Johan E"},
                new Person() { Name="Timothy"},
                new Person() { Name="Jimmy"},
                new Person() { Name="Eric"},
                new Person() { Name="Christoffer"},
                new Person() { Name="Dennis"},
                new Person() { Name="Aladin"},
                new Person() { Name="Joel"},
                new Person() { Name="Simon"},
                new Person() { Name="Tim K"},
                new Person() { Name="Samuel"},
                new Person() { Name="Carina"},
                new Person() { Name="Toni"},

            };
        }
        public static Group[] GroupUp(int groupSize)
        {
            if (groupSize<1)
            {
                return null;
            }
            int numGroups = Students.Count / groupSize;
            if (numGroups < 1)
                numGroups = 1;
            int overflow = Students.Count % groupSize;

            var groups = new Group[numGroups];
            for (int i = 0; i < groups.Length; i++)
            {
                groups[i] = new Group();
            }

            Randomize();

            for (int i = 0; i < Students.Count; i++)
            {
                groups[i % numGroups].Add(Students[i].Name);
            }

            return groups;
        }

        private static void Randomize()
        {
            Random rand = new Random();
            for (int i = 0; i < Students.Count; i++)
            {
                swap(i, rand.Next(Students.Count));
            }
        }

        private static void swap(int i, int v)
        {
            var tmp = Students[i];
            Students[i] = Students[v];
            Students[v] = tmp;
        }

        private class Person
        {
            public string Name;
        }
    }
}
