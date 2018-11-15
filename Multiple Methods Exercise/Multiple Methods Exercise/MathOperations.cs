using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Methods_Exercise
{
    public class Calculator
    {
        public Calculator()
        {
           
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Subtract(double num1, double num2)
        {
            return Convert.ToInt32(num1 - num2);
        }

        public int Add(string one, string two)
        {
            int x = 0;
            int y = 0;
            if (!Int32.TryParse(one, out x))
            {
                x = -1;
            }
            if (!Int32.TryParse(two, out y))
            {
                y = -1;
            }
            return x + y;
        }
    }
}
