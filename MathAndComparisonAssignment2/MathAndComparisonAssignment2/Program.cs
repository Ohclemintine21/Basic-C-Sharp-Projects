using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Title
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            //Person 1 Details
            Console.WriteLine("Person 1");
            Console.ReadLine();

            Console.WriteLine("Hourly Rate?");
            Console.WriteLine(15);
            Console.ReadLine();

            Console.WriteLine("Hours worked per week?");
            Console.WriteLine(40);
            Console.ReadLine();

            //Person 2 Details
            Console.WriteLine("Person 2");
            Console.ReadLine();

            Console.WriteLine("Hourly Rate?");
            Console.WriteLine(20);
            Console.ReadLine();

            Console.WriteLine("Hours worked per week?");
            Console.WriteLine(40);
            Console.ReadLine();

            //Annual Salary Person 1
            Console.WriteLine("Annual Salary of Person 1:");
            Console.WriteLine(31200);
            Console.ReadLine();

            //Annual Salary Person 2
            Console.WriteLine("Annual Salary of Person 2:");
            Console.WriteLine(41600);
            Console.ReadLine();

            //Compare Salaries Person 1 to Person 2
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.ReadLine();

            bool no = false;
            bool yes = true;
            if (no == false)
            {
                Console.WriteLine("false");
            }
            else if (yes == true)
            {
                Console.WriteLine("true");
            }
            Console.ReadLine();
        }
    }
}





