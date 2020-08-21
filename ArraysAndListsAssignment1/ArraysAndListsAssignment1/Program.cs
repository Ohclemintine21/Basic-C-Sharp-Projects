using System;
using System.Collections.Generic;


namespace ArraysAndListsAssignment1
{
    class Program
    {
        static void Main()
        {
            //User chooses an index from the array and then it displays the string at that index on the screen
            Console.WriteLine("Choose a food!");
            var f = Convert.ToInt32(Console.ReadLine());

            List<string> intList = new List<string>();
            intList.Add("Pizza");
            intList.Add("Cake");
            intList.Add("Burrito");

            Console.WriteLine(intList[f]);
            Console.ReadLine();

            //Error message if else statement

            if (f < intList.Count)
            {
                Console.WriteLine(intList[f]);
            }
            else
            {
                Console.WriteLine("Error, character not in list");
            }
            Console.ReadLine();

            //User chooses an index from the array and then it displays the integer at that index on the screen
            Console.WriteLine("Choose a number!");
            var num = Convert.ToInt32(Console.ReadLine());

            int[] numArray = new int[5];
            numArray[0] = 6;
            numArray[1] = 8;
            numArray[2] = 35;
            numArray[3] = 40;
            numArray[4] = 50;

            Console.WriteLine(numArray[num]);

            //Error message display if number does not exist

            if (num < numArray.Length)
            {
                Console.WriteLine(numArray[num]);  
            }
            else
            {
                Console.WriteLine("Error, number not in list");
            }

            //Ask user to select an index of the list and then display the content at that index on the screen
            Console.WriteLine("Choose a Character.");
            var c = Convert.ToInt32(Console.ReadLine());

            List<string> intList2 = new List<string>();
            intList2.Add("Peter Pan");
            intList2.Add("Cinderella");
            intList2.Add("Bugs Bunny");

            Console.WriteLine(intList2[c]);
            Console.ReadLine();

            if (c < intList2.Count)
            {
                Console.WriteLine(intList2[c]);
            }
            else
            {
                Console.WriteLine("Error, character not in list");
            }
            Console.ReadLine();
        }
    }
}
