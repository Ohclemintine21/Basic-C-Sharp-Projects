using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndListsAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //User chooses an index from the array and then it displays the string at that index on the screen
            Console.WriteLine("Choose a food!");
            List<string> intList = new List<string>();
            intList.Add("Pizza");
            intList.Add("Cake");
            intList.Add("Burrito");

            Console.WriteLine(intList[""]);
            Console.ReadLine();

            //User chooses an index from the array and then it displays the integer at that index on the screen
            Console.WriteLine("Choose a number!");
            int[] numArray = new int[5];
            numArray[0] = 6;
            numArray[1] = 8;
            numArray[2] = 35;
            numArray[3] = 40;
            numArray[4] = 50;
           
            
            MessageBox.Show("number does not exist. Try again");
            Console.WriteLine(numArray[""]);
            Console.ReadLine();

            //Ask user to select an index of the list and then display the content at that index on the screen
            Console.WriteLine("Choose a Character.");
            List<string> intList = new List<string>();
            intList.Add("Peter Pan");
            intList.Add("Cinderella");
            intList.Add("Bugs Bunny");

            Console.WriteLine(intList[""]);
            Console.ReadLine();

        }
    }
}
