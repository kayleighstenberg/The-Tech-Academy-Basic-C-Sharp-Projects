using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Kayleigh Stenberg";
            string location = "\n Denver, CO";
            string hobbies = "\n likes to go hiking and skiing.";

            name = name.ToUpper();
            location = location.ToUpper();

            Console.WriteLine(name+location+hobbies);
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append ("My name is Kayleigh Stenberg.");
            Console.WriteLine(sb);
            Console.ReadLine();
            StringBuilder builder = new StringBuilder();
            builder.Append("I live in Denver, Colorado.");
            Console.WriteLine(builder);
            Console.ReadLine();
            StringBuilder builder2 = new StringBuilder();
            builder2.Append("I like to go hiking in the summer, and skiing in the winter.");
            Console.WriteLine(builder2);
            Console.ReadLine();
            StringBuilder builder3 = new StringBuilder();
            builder3.Append("I am married and have two dogs named Leeloo and Rayden.");
            Console.WriteLine(builder3);
            Console.ReadLine();

           
        }
    }
}
