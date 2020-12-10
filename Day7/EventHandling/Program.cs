using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandling
{
    class Program
    {
        static void Main()
        {
            //create an object of Class1
            Class1 obj = new Class1();

            //make the event (delegate object) point to the event handler function written by us 
            obj.InvalidP1 += obj_InvalidP1;

            //event is fired only if value > 99
            obj.P1 = 200;
            Console.ReadLine();
        }

        private static void obj_InvalidP1()
        {
            Console.WriteLine("InvalidP1 event code here");
        }
    }
    //step 1 : create the delegate class having the same signature as the event handler function
    public delegate void InvalidP1EventHandler();

    //programmer write this class
    public class Class1
    {
        //step 2 : declear the event of the delegate class type (delegate object)
        public InvalidP1EventHandler InvalidP1;
        
        private int p1;
        public int P1
        {
            get
            {
                return p1;
            }

            set
            {
                if (value < 100)
                    p1 = value;
                else
                {
                    //raise the event here
                    //step 3 : call the delegate object
                    InvalidP1();
                }
            }
        }
    }

}
