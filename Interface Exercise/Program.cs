﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";

            employee.SayName();
            Console.ReadLine();

            Quit(employee);
            Console.ReadLine();

        }

        static void Quit(IQuittable quittable)
        {
            quittable.Quit();
        }
    }
}
