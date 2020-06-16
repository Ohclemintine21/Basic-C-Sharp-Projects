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
            List<string> intList = new List<string>();
            intList.Add("Pizza");
            intList.Add("Cake");
            intList.Add("Burrito");

            Console.WriteLine(intList[0]);
            Console.ReadLine();

            //User chooses an index from the array and then it displays the integer at that index on the screen
            Console.WriteLine("Choose a number!");
            int[] numArray = new int[5];
            numArray[0] = 6;
            numArray[1] = 8;
            numArray[2] = 35;
            numArray[3] = 40;
            numArray[4] = 50;

            Console.WriteLine(numArray[0]);

            //Error message display if number does not exist

            try
            {
                int[] numArrays = { 6, 8, 35, 40, 50 };
                Console.WriteLine(numArrays[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();

            //Ask user to select an index of the list and then display the content at that index on the screen
            Console.WriteLine("Choose a Character.");
            List<string> intList2 = new List<string>();
            intList2.Add("Peter Pan");
            intList2.Add("Cinderella");
            intList2.Add("Bugs Bunny");

            Console.WriteLine(intList2[0]);
            Console.ReadLine();

        }
    }
}
