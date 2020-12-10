using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main1()
        {
            Class1 o = new Class1();
            o.P4 = 123;
            Console.WriteLine(o.P4);
        }

        static void Main()
        {
            Class1 o;
            o = new Class1();
          Console.WriteLine(o.P1);

            Console.ReadLine();
        }
    }
    public class Class1
    {
        public Class1()
        {
            Console.WriteLine("Non-parameterized constructor");
            P1 = 5;
        }
        public Class1(int a)
        {
            Console.WriteLine("Parameterized constructor");
            P1 = a;
        }
        #region property
        //auto-property
        public int P4 { get; set; }
        #endregion
    }
}
