using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_IO_Exercise
{
    class Program
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Please enter a number.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            int[] number = new int[] {userInput};

            using (StreamWriter sw = new StreamWriter(@"C:\Users\Student\Logs\number.txt"))
            {
                for (int i = 0; i < 1; i++)
                {
                    sw.WriteLine(userInput);
                }
            }

            string text = File.ReadAllText(@"C:\Users\Student\Logs\number.txt");

            Console.WriteLine("Your number is: {0}", userInput);

            Console.ReadKey();
        }
    }
}
