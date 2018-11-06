using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        /*strings section*/

        Console.WriteLine("Please enter an index value: (1-7)");
        string[] colorArray = new string [] { "blue", "purple", "pink", "orange", "yellow", "green", "silver" };
        try
        {
            Console.WriteLine(colorArray[Convert.ToByte(Console.ReadLine()) - 1]);
        }

        catch (System.IndexOutOfRangeException)
        {
            System.Console.WriteLine("That index does not exist. Please try again.");

        }
        Console.WriteLine("Please enter an index value: (1-7)");
        Console.WriteLine(colorArray[Convert.ToByte(Console.ReadLine()) - 1]);
        Console.ReadLine();

        /*int section*/

        Console.WriteLine("Please enter another index value: (1-7)");
        int[] numArray = new int[] { 2, 5, 10, 25, 50, 75, 100 };
        try
        {
            Console.WriteLine(numArray[Convert.ToByte(Console.ReadLine()) - 1]);
        }

        catch
        {
            System.Console.WriteLine("That index does not exist.");
        }
        Console.WriteLine("Please enter another index value: (1-7)");
        Console.WriteLine(numArray[Convert.ToByte(Console.ReadLine()) - 1]);
        Console.ReadLine();


        /*List section*/
        Console.WriteLine("Please enter a final index value: (1-7)");
        List<string> animals = new List<string>();
        animals.Add("Dog");
        animals.Add("Cat");
        animals.Add("Horse");
        animals.Add("Bird");
        animals.Add("Lion");
        animals.Add("Tiger");
        animals.Add("Bear");
        
        try
        {
            Console.WriteLine(animals[Convert.ToByte(Console.ReadLine()) - 1]);
        }

        catch
        {
            System.Console.WriteLine("That index does not exist.");
        }

        Console.WriteLine("Please enter a final index value: (1-7)");
        Console.WriteLine(animals[Convert.ToByte(Console.ReadLine()) - 1]);
        Console.ReadLine();
    }
    }



