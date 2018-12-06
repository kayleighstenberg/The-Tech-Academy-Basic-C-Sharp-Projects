using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Exercise
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter the current day of the week.");
            string dayValue = Console.ReadLine();

            try
            {
                Day day = (Day)Enum.Parse(typeof(Day), dayValue);
            }

            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.ReadLine();
        }
    }
}
