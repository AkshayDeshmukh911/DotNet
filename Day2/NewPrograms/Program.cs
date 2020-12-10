using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace NewPrograms
{
    class Program
    {
        static void Main()
        {
            Class1 o = new Class1();
            //positional parameters
            Console.WriteLine(o.Add(10, 20, 30, 40));
            Console.WriteLine(o.Add(10, 20, 30));
            Console.WriteLine(o.Add(10, 20));

            Console.WriteLine(o.Add2(a: 40,b: 30, c: 20, d: 910));
            
        }
    }

    public class Class1
    {

        //optional parameters with default values
       public int Add(int a = 0, int b = 0, int c = 0, int d = 0)
        {
            return a + b + c + d;
        }
        public int Add(int a, int b, int c)
        {
           return a + b + c ;
        }
        public int Add(int a, int b)
        {
            return a + b ;
        }
        public int Add2(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
    }
}

namespace n2
{
    class C3
    {

    }
    class Class2
    {

    }
    namespace n3
    {
        class class4
        {

        }
    }
}
