using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructCode
{
    class Program
    {
        static void Main()
        {
        }

        public struct Student
        {
            private string name;
            private int rollNo;
            private decimal marks;

            public string Name { get; set; }
            public int RollNo { get; set; }
            public decimal Marks { get; set; }

            public Student(string name, int rollNo, decimal marks)
            {
                this.Name = name;
                this.RollNo = rollNo;
                this.Marks = marks;
            }
        }
    }
}
