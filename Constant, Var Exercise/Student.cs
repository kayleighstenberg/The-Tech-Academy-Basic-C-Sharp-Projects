using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant__Var_Exercise
{
   public class Student
    {
        public Student() : this("","")
        {
        }

        public Student(string name, string city) 
        {
            const string studentName = "Kayleigh";
            var City = "Denver";
            Console.WriteLine("Student name = {0}, City = {1}", studentName, City);
        }
    }
}
