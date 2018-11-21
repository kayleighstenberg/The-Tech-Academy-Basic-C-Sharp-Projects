
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_Operator_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Harry";
            person1.LastName = "Potter";
            person1.ID = 22;
            person1.SayName();
            Console.ReadLine();

            Person person2 = new Person();
            person2.FirstName = "Hermione";
            person2.LastName = "Granger";
            person2.ID = 11;
            person2.SayName();
            Console.ReadLine();

            if (person1 == person2)
                Console.WriteLine("Harry Potter and Hermione Granger have the same Employee IDs.");
            else
                Console.WriteLine("Harry Potter and Hermione Granger do not have the same Employee IDs.");
            Console.ReadLine();
        }
    }
}
