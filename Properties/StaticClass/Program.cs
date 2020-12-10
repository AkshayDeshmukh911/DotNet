using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    class Program
    {
        static void Main1()
        {
            Class1 o1 = new Class1();
            Class1 o2 = new Class1();
            o1.i = 100;
            o2.i = 200;

            Class1.s_i = 1234;
            Console.WriteLine(Class1.s_i);
            Console.WriteLine(o1.i);
            Console.WriteLine(o2.i);

            o1.display();
            Class1.display1();

            Class1.s_P1 = 10;
            Console.WriteLine(Class1.s_P1);

            Console.ReadLine();
        }
        static void Main()
        {
            Class2.display();
        }
    }
    public class Class1
    {
        public Class1()
        {
            Console.WriteLine("constrctor get called");
        }
        static Class1()
            {
            Console.WriteLine("static one");
            }
        public int i;
        //static variable-single copy for the class
        public static int s_i;

        //non-static method
        public void display()
        {
            Console.WriteLine(i);
            Console.WriteLine(s_i);
        }

        //static method
        public static void display1()
        {
            //Console.WriteLine(i);
            Console.WriteLine(s_i);
        }

        private int p1;
        public int P1
        {
            set
            {
                if (value < 100)
                {
                    p1 = value;
                }
                else
                {
                    Console.WriteLine("value is incorrect");
                }
            }
            get
            {
                return p1;
            }
        }

        private static int s_p1;
        public static int s_P1
        {
            set
            {
                if (value < 100)
                {
                    s_p1 = value;
                }
                else
                {
                    Console.WriteLine("value is incorrect");
                }
            }
            get
            {
                return s_p1;
            }
        }
    }
    public static class Class2
    {
        public static void display()
        {
            Console.WriteLine("static class is called");
        }
    }
}
