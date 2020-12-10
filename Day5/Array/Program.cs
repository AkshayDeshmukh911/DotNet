using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main1()
        {
            //System.Array
            int[] arr = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("enter element no {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Array.Clear(arr, 0, 5);
            // Array.Copy(arr, arr2, 5);
            // Array.ConstrainedCopy;
            // int pos = Array.IndexOf(arr, 10);
            // int pos1 = Array.LastIndexOf(arr, 10);
            // int pos3 = Array.BinarySearch(arr, 10);
            foreach(int x in arr)
            {
                Console.WriteLine("value is {0}", x);
            }

        }

        static void Main2()
        {
            /* 
              int[,] arr = new int[5, 3];   // (,)comma is told us diamensions of array [rows, column]
              for(int i = 0; i < 5; i++)
              {
                  for (int j = 0; i < 3; i++)
                  {
                      Console.WriteLine("Enter marks for student number {0} and subject {1}", i, j);
                      arr[i, j] = Convert.ToInt32(Console.ReadLine());
                  }
              }
            */

            int[,] arr= new int[5, 3];
            Console.WriteLine(arr.Length);

            Console.WriteLine(arr.Rank);
            Console.WriteLine(arr.GetLength(0));
            Console.WriteLine(arr.GetLength(1));

            Console.WriteLine(arr.GetUpperBound(0));
            Console.WriteLine(arr.GetUpperBound(1));

            Console.WriteLine(arr.GetLowerBound(0));
            Console.WriteLine(arr.GetLowerBound(1));

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; i < 3; i++)
                {
                    Console.WriteLine("Enter marks for student number {0} and subject {1}", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();
        }

        static void Main()
        {
            int[][] arr = new int[5][];
            arr[0] = new int[3];          //arr[0][0] - arr[0][2]
            arr[1] = new int[4];
            arr[2] = new int[5];
            arr[3] = new int[4];
            arr[4] = new int[6];

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine("Enter marks for student number [{0}][{1}]", i, j);
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine("Enter marks for student number [{0}][{1}] and marks", i, j);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
