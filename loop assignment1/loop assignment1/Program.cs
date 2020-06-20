using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {


        // a one-dimensional array of strings with user input text

        List<string> stringList = new List<string>();
        stringList.Add("Hello");
        stringList.Add("Welcome back");
        stringList.Add("How are you?");
        string Answer = Console.ReadLine();
        stringList.Add(Answer);

        for (var i = 0; i < stringList.Count; i++)
        {
            Console.WriteLine(stringList[i]);
        }
        Console.ReadLine();

        //while (true)
        //{
        //    for (var i = 0; i < stringList.Count; i++)
        //    {
        //        Console.WriteLine(stringList[i]);
        //    }
        //}

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine(i);
        }

        for (int i = 0; i <= 3; i++)
        {
            Console.WriteLine(i);
        }

        List<string> stringList2 = new List<string>();
        stringList2.Add("cat");
        stringList2.Add("fish");
        stringList2.Add("dog");
        stringList2.Add("bunny");
        stringList2.Add("Add another animal to the list");
        string animal = Console.ReadLine();
        stringList2.Add(animal);

        for (var A = 0; A < stringList2.Count; A++)
        {
            Console.WriteLine(stringList2[A]);

            if (A < stringList2.Count)
            {
                Console.WriteLine(stringList2[A]);
                    break;
            }
            else
            {
                Console.WriteLine("Error, animal not in list");
            }
            Console.ReadLine();
        }

        List<string> stringList3 = new List<string>();
        stringList3.Add("Monstera delicosa");
        stringList3.Add("Monstera delicosa");
        stringList3.Add("Monstera adansonii");
        stringList3.Add("Hoya ovata");
        stringList3.Add("Fatsia japanica");
        stringList3.Add("Search for plants in list.");
        string plants = Console.ReadLine();
        stringList3.Add(plants);

        if  (plants == "Monstera delicosa")
        {
            Console.WriteLine(plants);
        }
        else
        {
            Console.WriteLine("Error, plant is not in current list. Try again!");
        }
        Console.ReadLine();


        List<string> stringList4 = new List<string>();
        stringList4.Add("Sequioa NP");
        stringList4.Add("Redwood NP");
        stringList4.Add("Yosemite NP");
        stringList4.Add("Yosemite NP");
        stringList4.Add("Arches NP");
       
        var Parks = Console.ReadLine();
        stringList3.Add(Parks);

        foreach (var Park in Parks)
        {  
        Console.WriteLine("Park has appeared already" + Park);
        }
        Console.ReadLine();
    }
}

    


