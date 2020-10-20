using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { EmployeeFirstName = "Sally", EmployeeLastName = "Smith", EmployeeId = 1 });
            employees.Add(new Employee() { EmployeeFirstName = "Terry", EmployeeLastName = "Rikes", EmployeeId = 2 });
            employees.Add(new Employee() { EmployeeFirstName = "May", EmployeeLastName = "Parker", EmployeeId = 3 });
            employees.Add(new Employee() { EmployeeFirstName = "Joe", EmployeeLastName = "Miles", EmployeeId = 4 });
            employees.Add(new Employee() { EmployeeFirstName = "Jim", EmployeeLastName = "Joels", EmployeeId = 5 });
            employees.Add(new Employee() { EmployeeFirstName = "April", EmployeeLastName = "Becks", EmployeeId = 6 });
            employees.Add(new Employee() { EmployeeFirstName = "Mark", EmployeeLastName = "Teer", EmployeeId = 7 });
            employees.Add(new Employee() { EmployeeFirstName = "Nicky", EmployeeLastName = "Jiles", EmployeeId = 8 });
            employees.Add(new Employee() { EmployeeFirstName = "Jeff", EmployeeLastName = "Smith", EmployeeId = 9 });
            employees.Add(new Employee() { EmployeeFirstName = "Joe", EmployeeLastName = "Jolly", EmployeeId = 10 });
            foreach (var Joe in employees)
            {
                if (Joe.EmployeeFirstName == "Joe")
                {
                    Console.WriteLine(Joe.EmployeeFirstName);
                }
            }
            Console.ReadLine();
            List<Employee> nameList = new List<Employee>();
            nameList = employees.Where(x => x.EmployeeFirstName == "Joe").ToList();
            foreach (var x in nameList)
            {
                Console.WriteLine(x.EmployeeFirstName);
                Console.ReadLine();
            }
            List<Employee> idList = new List<Employee>();
            idList = employees.Where(y => y.EmployeeId > 5).ToList();
            foreach (var y in idList)
            {
                Console.WriteLine(y.EmployeeId);
                Console.ReadLine();
            }
        }
    }
}
