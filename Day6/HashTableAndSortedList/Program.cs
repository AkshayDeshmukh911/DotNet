using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTableAndSortedList
{
    class Program
    {
        //using System.Collection
        static void Main1()
        {
            SortedList objDictionary = new SortedList();
            objDictionary.Add(1, "abc");
            objDictionary.Add(2, "def");
            objDictionary.Add(3, "ghi");

            objDictionary[3] = "new value";
            objDictionary[4] = "aaaaaaa";

           // objDictionary.Remove(2);

            Console.WriteLine();
            foreach(DictionaryEntry de in objDictionary)
            {
                Console.WriteLine(de.Key);
                Console.WriteLine(de.Value);

            }
        }

        //using System.Collections.Generics
        static void Main()
        {
            SortedList<int, string> objDictionary = new SortedList<int, string>();
            objDictionary.Add(1, "abc");
            objDictionary.Add(2, "def");
            objDictionary.Add(3, "ghi");

            objDictionary[3] = "new value";
            objDictionary[4] = "aaaaaaa";

            // objDictionary.Remove(2);

            Console.WriteLine();
            foreach (KeyValuePair<int, string> de in objDictionary)
            {
                Console.WriteLine(de.Key);
                Console.WriteLine(de.Value);
            }
         }
    }
}
