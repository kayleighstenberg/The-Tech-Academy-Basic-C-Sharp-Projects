using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Exercise
{
    public class MethodParameters
    {
        static void Main()
        {
            Console.WriteLine("Pick a number:");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Addition a = new Addition();
            int x = a.AddTwoValues(10, 20);
            int y = a.AddThreeValues(10, 20, 30);
            int z = a.AddFourValues(10, 20, 30, 40);

            Console.WriteLine(x + userInput);
            Console.WriteLine(y + userInput);
            Console.WriteLine(z + userInput);
            Console.ReadLine();
        }
    }
}
