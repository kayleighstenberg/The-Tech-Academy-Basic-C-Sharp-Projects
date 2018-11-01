using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();
            Console.WriteLine("Please enter the package weight:");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            string result = packageWeight > 50 ? "Package too heavy to be shipped via Package Express. Have a good day." : "Thank you, please continue.";
            Console.WriteLine(result);
            Console.ReadLine();

            Console.WriteLine("Please enter package width:");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter package height:");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            int total = packageWidth + packageHeight + packageLength;

            if (total > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
            }
            Console.ReadLine();
    
            int product = packageWeight * (Convert.ToInt32 (total));
            
            
            decimal quotient = (decimal) product / 100m;

            Console.WriteLine("Your estimated total for shipping this package is: " + quotient.ToString ("C", CultureInfo.GetCultureInfo("en-us")));
            Console.WriteLine("Thank you.");

            Console.ReadLine();

        }
    }
}
