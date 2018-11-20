using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Exercise
{
    class Employee : Person, IQuittable
    {

        public override void SayName()
        {
            Console.WriteLine("The employee's name is: " + firstName + " " + lastName);
        }

        public void Quit(Employee employee)
        {
            throw new NotImplementedException();
        }

        public override void Quit()
        {
            Console.WriteLine("The employee " + firstName + " " + lastName + " " + "has quit");
        }
    }
}