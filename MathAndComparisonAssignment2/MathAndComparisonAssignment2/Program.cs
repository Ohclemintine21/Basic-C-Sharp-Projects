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
            int hourlyRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(hourlyRate);
            Console.ReadLine();

            Console.WriteLine("Hours worked per week?");
            int hoursWorked = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(hoursWorked);
            Console.ReadLine();

            //Person 2 Details
            Console.WriteLine("Person 2");
            Console.ReadLine();

            Console.WriteLine("Hourly Rate?");
            int hourlyRate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(hourlyRate2);
            Console.ReadLine();

            Console.WriteLine("Hours worked per week?");
            int hoursWorked2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(hoursWorked2);
            Console.ReadLine();

            //Annual Salary Person 1
            Console.WriteLine("Annual Salary of Person 1:");
            int AnnSalary1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(AnnSalary1);
            Console.ReadLine();

            //Annual Salary Person 2
            Console.WriteLine("Annual Salary of Person 2:");
            int AnnSalary2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(AnnSalary2);
            Console.ReadLine();

            //Compare Salaries Person 1 to Person 2
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.ReadLine();

            int Person1 = 31200;
            int Person2 = 41600;
            bool compareResult = (Person1 > Person2);
            Console.WriteLine(compareResult);
            Console.ReadLine();
        }
    }
}





