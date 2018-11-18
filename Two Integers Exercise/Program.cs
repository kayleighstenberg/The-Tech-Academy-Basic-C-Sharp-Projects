using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Two_Integers_Exercise
{
    class Program
    {
        public static void Main()
        {
            
            Console.WriteLine("Please enter an integer.");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a second integer (it is not necessary).");
            int y = 0;
            try
            {
                 y = Convert.ToInt32(Console.ReadLine());
            }
            catch 
            {
                Console.WriteLine("Nothing was entered for second integer");
            }
            

            Example add = new Example();
            add.AddNumbers(x, new int[] { y });
            
            Console.ReadLine();


            }
    }
}
