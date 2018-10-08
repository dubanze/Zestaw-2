using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw_2
{
    class Program
    {
        static string[] ReturnNonEmptyStringTable(string[] table)
        {
            return Array.FindAll(table, s => s != string.Empty);
        }

        static void Main(string[] args)
        {
            int[] table1 = new int[100000000];
            var numRand = new Random();
            for (int i = 0; i < table1.Length; i++)
            {
                table1[i] = numRand.Next(0, 100000000);
            }

            Array.Sort(table1);
            VariableParams(1, 2, 3);
            VariableParams(3, 4, 5,5,7,2,5,8);
            

            ////////////////////////////

            var sTable = new []
            {
                "Pompa","Costam",String.Empty, "Hejeczka",String.Empty
            };

            var sTableCopy = ReturnNonEmptyStringTable(sTable);

            // zaimplementować metodę, która będzie zwracała wszystkie stringi, które nie sa puste

            ////////////////////////
            
            List<int> IntegersList = new List<int>();
            IntegersList.Add(1);
            IntegersList.Add(2);
            IntegersList.Add(3);
            IntegersList.Remove(1);
            IntegersList.Remove(2);
            IntegersList.Remove(3);
            Dictionary<string,string> Dictionary = new Dictionary<string, string>();
            Dictionary.Add("Castle","Zamek");
            Dictionary.Add("Petard", "Petarda");
            Dictionary.Add("River", "Rzeka");
            Dictionary.Remove("Castle");
            Dictionary.Remove("Petard");
            Dictionary.Remove("River");
            Queue<int> Queue = new Queue<int>();
            Queue.Enqueue(1);
            Queue.Enqueue(2);
            Queue.Enqueue(3);
            Queue.Dequeue();
            Queue.Dequeue();
            Queue.Dequeue();
            Stack<int> Stack = new Stack<int>();
            Stack.Push(1);
            Stack.Push(2);
            Stack.Push(3);
            Stack.Pop();
            Stack.Pop();
            Stack.Pop();
        }

        

        public static int VariableParams(params int[] list)
        {
            Console.WriteLine(list.Length);
            return list.Length;
            //int sum=0;
            //foreach (var param in list)
            //{
            //    sum++;
            //}
            //Console.WriteLine(sum);
            //return sum;
        }
    }

    class Person
    {
        public int Age { get; set; }
    }

    public class PersonSorter
    {
        private bool ascending;

        public PersonSorter(bool ascending)
        {
            this.ascending = ascending;
        }

        class AgeComparer : IComparer<Person>
        {
            private PersonSorter sorter;

            public AgeComparer(PersonSorter sorter)
            {
                this.sorter = sorter;
            }

            public int Compare(Person x, Person y)
            {
                if (x?.Age == y?.Age)
                    return 0;
                if (x?.Age < y?.Age)
                    return sorter.ascending ? -1 : 1;
                return sorter.ascending ? 1 : -1;
            }
        }
    }
}

