using System;
using System.Collections.Generic;


    class Program
    {
    static void Main()
    {
        Console.WriteLine("Please select an index from the list below:");

        List<string> animals = new List<string>();
        animals.Add("Dog");
        animals.Add("Cat");
        animals.Add("Horse");
        animals.Add("Bird");
        animals.Add("Lion");
        animals.Add("Tiger");
        animals.Add("Bear");

        //int index1 = 0;
        //int index2 = 1;
        //int index3 = 2;
        //int index4 = 3;
        //int index5 = 4;
        //int index6 = 5;
        //int index7 = 6;

        Console.WriteLine();
        foreach (string animal in animals )
        {
            Console.WriteLine(animal);
        }


            Console.ReadLine();
    }
    }

