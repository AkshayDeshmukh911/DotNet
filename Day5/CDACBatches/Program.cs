using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CDACBatches
{
    class Program
    {
        static void Main()
        {
            int b;
            b = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the NO.of batches in cdac : " + b);
            Console.WriteLine();
            Console.WriteLine();
            int[][] arr = new int[b][];

            for (int i = 0; i < b; i++)
            {
                Console.WriteLine($"Enter the No of students in batch " + i + " : ");
                int p = Convert.ToInt32(Console.ReadLine());
                arr[i] = new int[p];
                for (int j = 0; j < p; j++)
                {
                    Console.WriteLine($"Marks obtained to student no " + j);
                      arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine($"Batch {i+1} Student {j+1} marks are : "+arr[i][j]);
                }
                
            }
        }
    }
}
