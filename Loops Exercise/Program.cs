using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a color");
            string color = Convert.ToString(Console.ReadLine());
            bool isPicked = color == "blue";

            while (!isPicked) 
            {
                switch (color)
                {

                    case "yellow":
                        Console.WriteLine("You picked yellow. Please try again.");
                        Console.WriteLine("Pick a color?");
                        color = Convert.ToString(Console.ReadLine());
                        break;
                    case "purple":
                        Console.Write("You picked purple. Please try again.");
                        Console.WriteLine("Pick a color?");
                        color = Convert.ToString(Console.ReadLine());
                        break;
                    case "green":
                        Console.WriteLine("You picked green. Please try again.");
                        Console.WriteLine("Pick a color?");
                        color = Convert.ToString(Console.ReadLine());
                        break;
                    case "red":
                        Console.WriteLine("You picked red. Please try again.");
                        Console.WriteLine("Pick a color?");
                        color = Convert.ToString(Console.ReadLine());
                        break;
                    case "blue":
                        Console.WriteLine("You picked blue. That is correct!");
                        isPicked = true;
                        break;
                    default:
                        Console.WriteLine("That is incorrect.");
                        Console.WriteLine("Pick a color?");
                        color = Convert.ToString(Console.ReadLine());
                        break;

                }
            }
            

            Console.ReadLine();

        }
    }
}
