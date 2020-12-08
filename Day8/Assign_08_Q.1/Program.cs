using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmeent_Q1
{
    class Program
    {
        static void Main()
        {
            Func<decimal, decimal, decimal, decimal> o1 = (P, R, T) => (P * R * T) / 100;
            Console.WriteLine(o1(2000,14,12));
        }
        static decimal SimpleInterest(decimal P, decimal R, decimal T)
        {
            decimal SI;
           return  SI = (P * R * T)/100;
           
        }
    }
}
