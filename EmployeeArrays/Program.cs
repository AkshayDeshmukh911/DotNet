using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeArrays
{
    class Program
    {
        static void Main()
        {
            Employee[] arr = new Employee[3];
            Employee emp1 = new Employee(1, "Akshay", 120000);
            Employee emp2 = new Employee(2, "Amit", 130000);
            Employee emp3 = new Employee(3, "Akash", 123000);

            arr[0] = emp1;
            arr[1] = emp2;
            arr[2] = emp3;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].EmpSal > arr[j + 1].EmpSal)
                    {

                        Employee temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].EmpSal == arr[arr.Length - 1].EmpSal)
                    Console.WriteLine(arr[i].EmpId + " " + arr[i].EmpName + "  " + arr[i].EmpSal);
            }

            int eno = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].EmpId == eno)
                    Console.WriteLine(arr[i].EmpId + " " + arr[i].EmpName + "  " + arr[i].EmpSal);
            }
           // Console.ReadLine();
        }
    }

    public class Employee
    {
        private int empId;
        private string empName;
        private decimal empSal;

        public int EmpId
        {
            get;

            set;
        }
        public string EmpName { get; set; }
        public decimal EmpSal { get; set; }

        public Employee(int empId, string empName, decimal empSal)
        {
            this.EmpId = empId;
            this.EmpName = empName;
            this.EmpSal = empSal;
        }
    }
}
