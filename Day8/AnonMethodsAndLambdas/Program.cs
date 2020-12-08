using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonMethodsAndLambdas
{
    class Program
    {
        static void Main()
        {
            int i = 10;
            Func<int, int, int> o1 = Add;
            Console.WriteLine(o1(10,20));

            //Lambda Function
            Func<int, int, int> o2 = (a, b) => a + b;
            Console.WriteLine(o2(10,200));

            Func<int, int> o5 = a => a;
            Console.WriteLine(o5(7));

            //Anonymous Function 
            Func<int, int> o3 = Even;
            Console.WriteLine("result = " + o3(6));

            //Predicate<int> o4 = Even;
            //Console.WriteLine("result2 = "+o4(4));

            Action o = delegate ()
            {
                Console.WriteLine("Display");
                i++;
            };

            o();
            o();
            o();
            o();
            o();
            Console.WriteLine(i);
        }
       
        static int Add(int a, int b)
        {
            return a + b;
        }
        static void Display()
        {
            Console.WriteLine("Display");
        }

        //static bool Even(int a)
        //{   
        //    if(a%2==0)
        //    {
        //        return true;
        //    }
        //    else 
        //    {
        //        return false;
        //    }
        //}


        static int Even(int a)
        {
            if (a % 2 == 0)
            {
                return a;
            }
            else
            {
                return 0;
            }
        }

    }
}
