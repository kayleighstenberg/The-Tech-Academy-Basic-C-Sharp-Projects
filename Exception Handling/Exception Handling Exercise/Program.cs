using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Here is a list:");
                List<int> numbers = new List<int>();
                numbers.Add(20);
                numbers.Add(45);
                numbers.Add(60);
                numbers.Add(88);
                numbers.Add(100);
                numbers.ForEach(Console.WriteLine);
                Console.ReadLine();


                Console.WriteLine("Enter a number to divide each number in the list by:");
                int userInput = Convert.ToInt32(Console.ReadLine());
                int quotient = 0;

                foreach (int number in numbers)
                {
                    quotient = number / userInput;
                    Console.WriteLine(quotient);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("The program has emerged from the exception and continued on with program execution.");
                return;
            }

            finally
            {
                Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}