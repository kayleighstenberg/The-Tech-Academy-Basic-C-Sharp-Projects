using System;
using System.Collections.Generic;


class Program
{

    static void Main(string[] args)
    { /*String array section*/

        string[] numArray1 = new string[7] { "red", "green", "yellow", "blue", "purple", "orange", " " };

        for (int i = 0; i < numArray1.Length; i++)
        {

            Console.WriteLine(numArray1[i]);

        }
        Console.WriteLine("\n");
        Console.WriteLine("Please enter a color to add to the array:");
        numArray1[6] = Console.ReadLine();
        Console.WriteLine("\n");
        Console.WriteLine("Here is the new array:");

        for (int i = 0; i <= numArray1.Length - 1; i++)
        {

            Console.WriteLine(numArray1[i]);

        }

        while (true)
        {

            break;

        }
        /*First List*/

        Console.WriteLine("\n");
        Console.WriteLine("Next Question");
        Console.WriteLine("Please type the text of the animal index you want");
        Console.WriteLine("\n");
        List<string> animals = new List<string>();
        animals.Add("Dog");
        animals.Add("Cat");
        animals.Add("Horse");
        animals.Add("Bird");
        animals.Add("Lion");
        animals.Add("Tiger");
        animals.Add("Bear");

        for (int i = 0; i < animals.Count; i++)
        {

            Console.WriteLine(animals[i]);

        }

        string animalread = Console.ReadLine();


        int count = 0;
        foreach (string Item in animals)
        {
            if (Item.Contains(animalread))
            {
                Console.WriteLine(count);
                break;
            }
            else if (count == animals.Count - 1)
            {
                Console.WriteLine("I'm sorry this animal is not in the list!");
                break;
            }
            else
            {
                count = count + 1;
            }
        }
        /*Second List*/

        Console.WriteLine("\n");
        Console.WriteLine("Next Question");
        Console.WriteLine("Please type the text of the car manufacturer index you want");
        Console.WriteLine("\n");
        List<string> cars = new List<string>();
        cars.Add("Aston Martin");
        cars.Add("Ferrari");
        cars.Add("Lamborghini");
        cars.Add("Jaguar");
        cars.Add("Mercedes");
        cars.Add("Jaguar");

        for (int i = 0; i < cars.Count; i++)
        {

            Console.WriteLine(cars[i]);

        }

        string carinput = Console.ReadLine();
        count = 0;
        bool goodanswer = false;
        foreach (string Item in cars)
        {

            if (Item.Contains(carinput))
            {
                Console.WriteLine(count);
                goodanswer = true;

            }
            else if ((count == cars.Count - 1) & (goodanswer == false))
            {

                Console.WriteLine("I'm sorry this car is not in the list!");
                break;
            }

            count = count + 1;


        }
        /*Third List*/

        Console.WriteLine("\n");
        Console.WriteLine("Next Question");
        Console.WriteLine("\n");
        List<string> guitars = new List<string>();
        guitars.Add("Fender");
        guitars.Add("PRS");
        guitars.Add("Fender");
        guitars.Add("Ibanez");
        guitars.Add("Gibson");
        Dictionary<string, string> occurrences = new Dictionary<string, string>();

        var testset = new HashSet<string>();

        foreach (var Item in guitars)
        {
            if (!testset.Add(Item))
            {
                Console.WriteLine("List contains duplicate of: " + Item);
                break;
            }
        }


        Console.ReadLine();
    }
}






