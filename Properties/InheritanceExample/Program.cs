using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample1
{
    class Program
    {
        static void Main1()
        {
          // BaseClass o = new BaseClass();
             DerivedClass o = new DerivedClass();
            Console.WriteLine(o.a + "  " + o.b);
        }
    }
    public class BaseClass
    {
        public int a=20;
    }
    public class DerivedClass : BaseClass
    {
        public int b=10;
    }
}

namespace InheritanceExample2
{
    class Program
    {
        static void Main()
        {
            // BaseClass o = new BaseClass();
            DerivedClass o = new DerivedClass();
            Console.WriteLine(o.a + "  "+o.d+"  "+o.e+"  "+o.f);
        }
    }
    public class BaseClass
    {
        public int a = 20;
        private int b = 10;
        protected string c = "akshay";
        internal string d = "Amit";
        protected internal string e = "Sunny";
    }
    public class DerivedClass : BaseClass
    {
        public int f = 30;
    }
}
