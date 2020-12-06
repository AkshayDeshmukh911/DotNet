using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPractice
{
    class Program
    {
        static void Main()
        {
            // Display(0);
            Display1(Meet.Good_Bye);
        }
        static void Display(int t)
        {
            if(t == 0)
                Console.WriteLine("Hii");
            else if(t == 1)
                Console.WriteLine("Bye");
            else
                Console.WriteLine("Not ok");
        }
        static void Display1(Meet t)
        {
            if (t == Meet.Hello)
                Console.WriteLine("Hii");
            else if (t == Meet.Good_Bye)
                Console.WriteLine("Bye");
            else
                Console.WriteLine("Not ok");
        }
        public enum Meet
        {
            Hello,
            Good_Bye,
        }
    }
}
