using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program<T>
    {
        static void Main()
        {
            T i = 10;
            T j = 20;
            T s = "sunny";
            T r = "amit";
            Display(i,j);
            Display(s, r);
            
        }
    }
   public void Display( T i,  T j)
    {
        Console.WriteLine("Display "+i+" and "+j);
    }

}
