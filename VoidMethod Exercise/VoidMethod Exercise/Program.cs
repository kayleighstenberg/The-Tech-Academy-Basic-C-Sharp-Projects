using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod_Exercise
{
    public class Maximum
    {               
         static void Main(string[] args)
        {
            Console.WriteLine("First Number = ");
            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("Second Number = ");
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine("Greatest number of two: " + Math.Max(first, second));
            Console.ReadLine();

        }

    }
}
