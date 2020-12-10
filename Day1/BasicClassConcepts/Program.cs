using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data;

namespace BasicClassConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class2
            //BasicClassConcepts.Class2
            //n2.Class2
            //System.Data.DataSet
            //n2.n3.Class4
            //System.Console.WriteLine("Hello World");
            //System.Console.ReadLine();
            // System.Console.WriteLine("Hello Akshay Welcome in .Net world");
            //System.Data.DataSet ds = new System.Data.DataSet();

            Class1 o;
            o = new Class1();
            o.Display();
            o.Display("Akshay");
            Console.ReadLine();
              
        }
    }
    public class Class1
    {
        public void Display()
        {
            System.Console.WriteLine("Hello Akshay Welcome in .Net world");
        }

        //Function overloading
        public void Display(string s)
        {
            Console.WriteLine("Hello " +
                "" + s);
        }
    }
    class Class2
    { }
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
        class Class4
        {

        }
    }
}
