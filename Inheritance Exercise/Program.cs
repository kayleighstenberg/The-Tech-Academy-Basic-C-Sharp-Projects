using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise
{
    class Program
    {


        static void Main(string[] args)
        {

            Person person = new Person();
            person.FirstName = "John";
            person.LastName = "Wick";
            person.SayName();
            

            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();
            Console.ReadLine();
        }
    }


}
