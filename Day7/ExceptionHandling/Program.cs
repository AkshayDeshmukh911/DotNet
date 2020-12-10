using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main1()
      
        {
            DoSomething();
        }

        static void Main2()
        {
            DoSomething();  
        }


        static void DoSomething()
        {
            Class1 obj = new Class1();
            try
            {
                obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("x : " + x);
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");
            }
            catch(ArithmeticException)
            {
                Console.WriteLine("Arithmetic Exception occured");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Null reference ecxeption occured");
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception occured");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("finally");
            }
        }

        static void Main()// nested try block
        {
            Class1 obj = new Class1();
            try
            {
                obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");
            }
            catch (FormatException ex)
            {
                try
                {
                    Console.WriteLine("FormatException occurred. Enter only numbers");
                    int x = Convert.ToInt32(Console.ReadLine());
                    obj.P1 = 100 / x;
                    Console.WriteLine(obj.P1);
                }
                catch
                {
                    Console.WriteLine("nested try catch example");
                }
                finally
                {
                    Console.WriteLine("nested try finally example");
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NRException occurred");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DBException occurred");
            }
            catch (Exception ex) //catches all unhandled exceptions
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("finally");

            }
            Console.ReadLine();
        }
    }

    public class Class1
    {
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
                    Console.WriteLine("invalid P1");   //dont EVER do this

                    Exception ex;
                    //ex = new Exception();
                    ex = new Exception("Invalid P1");
                 //   ex = new InvalidP1Exception("Invalid P1");

                    throw ex;
                }
            }
        }
    }
}
