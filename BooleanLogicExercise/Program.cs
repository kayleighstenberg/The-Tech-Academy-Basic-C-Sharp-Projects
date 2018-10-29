using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Please type true or false.");
            string hadDUI = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            int numberOfTickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qualified?");

            bool isQualified = (age >= 15 && (numberOfTickets <= 3 && hadDUI == "false"));

            Console.WriteLine(isQualified);
            Console.ReadLine();


        }
    }
}
