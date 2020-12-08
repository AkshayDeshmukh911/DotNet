using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Implicit Variables
namespace LanguageFeatures
{
    class Program
    {
        static void Main()
        {
            int i;
            var i2 = 100;  //implicit variable
            var i3 =(short) 100;  //implicit variable
            //used only for local variables
            //cant be used for class level vars,fn params and return types
            //i2 = 200;
            Console.WriteLine(i2.GetType().ToString());
            Console.ReadLine();

           
        }
    }
}
