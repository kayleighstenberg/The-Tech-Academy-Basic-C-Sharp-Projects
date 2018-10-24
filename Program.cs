using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExercise1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Please enter a whole number");
            uint number1 = Convert.ToUInt32(Console.ReadLine());
            uint product = number1 * 50;
            Console.WriteLine(product);
            Console.ReadLine();

            Console.WriteLine("Please enter another whole number");
            uint number2 = Convert.ToUInt32(Console.ReadLine());
            uint total = number2 + 25;
            Console.WriteLine(total);
            Console.ReadLine();

            Console.WriteLine("Please enter another whole number");
            double number3 = Convert.ToDouble(Console.ReadLine());
            double quotient = number3 / 12.5;
            Console.WriteLine(quotient);
            Console.ReadLine();

            Console.WriteLine("Please enter another whole number");
            uint number4 = Convert.ToUInt32(Console.ReadLine());
            bool trueOrFalse = number4 > 50;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();

            Console.WriteLine("And finally, please enter another whole number");
            double number5 = Convert.ToDouble(Console.ReadLine());
            double quotient2 = number5 / 7.0;
            Console.WriteLine(quotient2);
            double remainder = quotient2 % 2;
            Console.WriteLine(remainder);
            Console.ReadLine();





        }
    }
}
