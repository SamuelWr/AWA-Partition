using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWA_Partition
{
    public static class PartitionUtils
    {
        public static List<Person> AllStudents { get; }
        static PartitionUtils()
        {
            AllStudents = new List<Person>();
            
            string[] p = File.ReadAllLines("Students.txt");
            foreach (var item in p)
            {
                AllStudents.Add(new Person { Name = item });
            }
            AllStudents.Sort();
        }
        public static Group[] GroupUp(IList<Person> students, int groupSize)
        {
            if (groupSize < 1)
            {
                return null;
            }
            int numGroups = students.Count / groupSize;
            if (numGroups < 1)
                numGroups = 1;
            int overflow = students.Count % groupSize;

            var groups = new Group[numGroups];
            for (int i = 0; i < groups.Length; i++)
            {
                groups[i] = new Group();
            }

            Randomize(students);

            for (int i = 0; i < students.Count; i++)
            {
                groups[i % numGroups].Add(students[i]);
            }

            return groups;
        }

        private static void Randomize(IList<Person> lista)
        {
            Random rand = new Random();
            //TODO: this is not properly randomizing!
            // should only swap forward
            // swap(i,i+rand.Next(lista.Count -i),lista);
            for (int i = 0; i < lista.Count; i++)
            {
                swap(i, rand.Next(lista.Count),lista);
            }
        }

        private static void swap(int i, int v, IList<Person> lista)
        {
            var tmp = lista[i];
            lista[i] = lista[v];
            lista[v] = tmp;
        }
        
    }
}
