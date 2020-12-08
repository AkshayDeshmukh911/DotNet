using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Q4
{
    class Program
    {
        static void Main()
        { 
            Predicate<int> o1 = num =>
            {
                if (num%2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
            Console.WriteLine(o1(18));
        }
    }
}
