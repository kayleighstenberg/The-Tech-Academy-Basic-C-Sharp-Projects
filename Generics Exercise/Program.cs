using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Exercise
{
    class Program
    {
        
        static void Main(string[] args)
        {

            List<string> Items = new List<string>();
            Items.Add("Desk");
            Items.Add("Computer");
            Items.Add("Mouse");
            Items.Add("Notebooks");
            Items.Add("Pens");

            List<int> Numbers = new List<int>();
            Numbers.Add(3);
            Numbers.Add(5);
            Numbers.Add(4);
            Numbers.Add(2);
            Numbers.Add(5);

            foreach (string item in Items)
            {
                Console.WriteLine(item);
            }
            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
