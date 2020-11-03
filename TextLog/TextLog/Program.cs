using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextLog
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask user for a number
            Console.WriteLine("Please enter a number. ");
            string userInput = Convert.ToString(Console.ReadLine());

            using (StreamWriter file = new StreamWriter(@"C:\Users\Student\\source\\Logs\\log.txt", true))
            {
                file.Write(userInput);

            }   
            Console.WriteLine(File.ReadAllText(@"C:\Users\Student\\source\\Logs\\log.txt"));
            
            Console.ReadLine();
        }
    }
}
