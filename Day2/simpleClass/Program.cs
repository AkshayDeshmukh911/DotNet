using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace simpleClass
{
    class Program
    {
        static void Main()
        {
            Class1 o = new Class1();

           // o.P1 = 10;

            //o.P2 = "a";

            //Console.WriteLine(o.P2);
            //Console.WriteLine(o.P1);
            Console.ReadLine();       
        }
    }
    public class Class1
    {
        public int i;
       
        public void Display()
        {
            Console.WriteLine("disp");
        }
        //static method
    }
}
