using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateClass
{
    //step 1 : create a delegate class having the same signature as the function to call

    public delegate void Del1();
    public delegate int DelAdd(int i, int j);

    class Program
    {
        static void Main1()
        {
            Del1 objDel;
            //Display();
            //step 2 : create a delegate object passing the function name as a parameter
             objDel = new Del1(Display);

            //step 3 : call the function via the delegate object
            objDel();
            Console.WriteLine();
            Console.WriteLine();

            objDel += new Del1(flow);
            objDel();
            Console.WriteLine();
            Console.WriteLine();

            objDel += new Del1(show);
            objDel();

           // objDel -= new Del1(show);
           // objDel();
            Console.ReadLine();
        }

        static void Main2()
        {
            Del1 objDel;
            objDel = Display;
            objDel();
            objDel += flow;
            objDel();
           // objDel += show();
        }

        static void Main3()
        {
            Del1 objDel = (Del1)Delegate.Combine(new Del1(Display),new Del1(flow), new Del1(show));
            objDel();
            Console.ReadLine();
        }

        static void Main4()
        {
            Del1 objDel;
             objDel = Display;
            objDel();
            objDel = flow;
            objDel();
            objDel = show;
            objDel();
            DelAdd objDelAdd = Add;
            objDelAdd(10,20);
            Console.WriteLine(objDelAdd(10, 20));
        }


        static void Display()
        {
            Console.WriteLine("disp1");
        }
        static void flow()
        {
            Console.WriteLine("disp2");
        }
        static void show()
        {
            Console.WriteLine("disp3");
        }
        static int Add(int i, int j)
        {
            return i + j;
        }
       
    }
}
