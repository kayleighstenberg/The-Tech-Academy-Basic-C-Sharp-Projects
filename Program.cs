using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate");
            int hourlyrate1 = Int32.Parse("20");
            Console.WriteLine(hourlyrate1);
            Console.WriteLine("Hours worked per week");
            int hoursworked1 = Int32.Parse("40");
            Console.WriteLine(hoursworked1);
            Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate");
            int hourlyrate2 = Int32.Parse("30");
            Console.WriteLine(hourlyrate2);
            Console.WriteLine("Hours worked per week");
            int hoursworked2 = Int32.Parse("40");
            Console.WriteLine(hoursworked2);
            Console.ReadLine();

            Console.WriteLine("Annual Salary of Person 1");
            int annualsalary1 = Int32.Parse("41600");
            Console.WriteLine(annualsalary1);
            Console.ReadLine();

            Console.WriteLine("Annual Salary of Person 2");
            int annualsalary2 = Int32.Parse("62400");
            Console.WriteLine(annualsalary2);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool higherSalary = annualsalary1 > annualsalary2;
            Console.WriteLine(higherSalary);
            Console.ReadLine();

        }
    }
}
