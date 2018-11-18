using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Two_Integers_Exercise
{
    public class Example
    {

        public void AddNumbers(int a, [Optional] int[] b)
        {
            int total = a + 10;
            if (b != null)
            {
                foreach (int i in b)
                {
                    total += i;
                }
            }
            Console.WriteLine("10 + integer one + integer two:");
            Console.WriteLine(total);    
        
        }
        
    }
}
