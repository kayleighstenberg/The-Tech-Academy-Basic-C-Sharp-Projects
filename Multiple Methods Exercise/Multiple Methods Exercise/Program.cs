﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Methods_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            int result = 0;
            result = calc.Multiply(12, 10);
            Console.WriteLine(result);
            Console.ReadLine();

            Calculator calc2 = new Calculator();
            int result2 = 0;
            result2 = calc2.Subtract(15, 2.2);
            Console.WriteLine(result2);
            Console.ReadLine();

            Calculator calc3 = new Calculator();

            int result3 = 0;
            result3 = calc3.Add("15", "5");
            Console.WriteLine(result3);
            Console.ReadLine();

        }
    }
}
