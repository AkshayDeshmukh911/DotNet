using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Q2
{
    class Program
    {
        static void Main()
        {
            Func<int, int,bool> o1 = (a, b) =>
              {
                  if (a > b)
                  {
                      return true;
                  }
                  else
                  {
                      return false;
                  }
              };
            Console.WriteLine(o1(120, 43));
        }


         static bool IsGreater(int a, int b)
             {
                if(a > b)
                {
                      return true;
                }
                else
                {
                return false;
            }
        }
    }
}
