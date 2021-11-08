using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMBDA
{
    class Program
    {
        static void Main(string[] args)
        {
            //ADDING JOE'S FOR LAMBDA ASSIGNMENT
            Employee<string> employee1 = new Employee<string>() { eID = 01, FirstName = "Wayde", LastName = "Watts" };
            Employee<string> employee2 = new Employee<string>() { eID = 02, FirstName = "Barry", LastName = "Allen" };
            Employee<string> employee3 = new Employee<string>() { eID = 03, FirstName = "Joe", LastName = "Wilson" };
            Employee<string> employee4 = new Employee<string>() { eID = 04, FirstName = "Steve", LastName = "Rodgers" };
            Employee<string> employee5 = new Employee<string>() { eID = 05, FirstName = "Tony", LastName = "Stark" };
            Employee<string> employee6 = new Employee<string>() { eID = 06, FirstName = "Bruce", LastName = "Wayne" };
            Employee<string> employee7 = new Employee<string>() { eID = 07, FirstName = "Joe", LastName = "Shmoe" };
            Employee<string> employee8 = new Employee<string>() { eID = 08, FirstName = "Sam", LastName = "Wilson" };
            Employee<string> employee9 = new Employee<string>() { eID = 09, FirstName = "T'Challa", LastName = "Udaku" };
            Employee<string> employee10 = new Employee<string>() { eID = 10, FirstName = "Scott", LastName = "Lang" };
            Employee<string> employee11 = new Employee<string>() { eID = 11, FirstName = "Joe", LastName = "Taylor" };
            Employee<string> employee12 = new Employee<string>() { eID = 12, FirstName = "Bruce", LastName = "Banner" };
            Employee<string> employee13 = new Employee<string>() { eID = 13, FirstName = "Steven", LastName = "Strange" };

            List<Employee<string>> employees = new List<Employee<string>>() 
            { employee1, employee2, employee3, employee4, employee5, employee6, employee7, employee8, employee9, employee10, employee11, employee12, employee13 };

            List<Employee<string>> eJoe = new List<Employee<string>>();

            foreach (Employee<string> employee in employees)
            {
                Console.WriteLine("{0} {1} {2}", employee.eID, employee.FirstName, employee.LastName);
            }


            foreach (Employee<string> employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    eJoe.Add(employee);
                }
            }

            Console.WriteLine("\nEach 'Joe' from new list:");
            foreach (Employee<string> employee in eJoe)
            {
                Console.WriteLine("{0} {1} {2}", employee.eID, employee.FirstName, employee.LastName);
            }

            // LAMBDA JOE FUNCTION
            Console.WriteLine("\nEach 'Joe' from new list using lambda function:");
            List<Employee<string>> eJoe2 = employees.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee<string> employee in eJoe2)
            {
                Console.WriteLine("{0} {1} {2}",employee.eID, employee.FirstName, employee.LastName);
            }

            //LAMBDA ID ABOVE 05
            Console.WriteLine("\nEvery employee with an ID above 05:");
            List<Employee<string>> employeeUp = employees.Where(x => x.eID > 05).ToList();
            foreach (Employee<string> employee in employeeUp)
            {
                Console.WriteLine("{0}: {1} {2}", employee.eID, employee.FirstName, employee.LastName);
            }


            Employee<string> eString = new Employee<string>();
            Employee<int> eInt = new Employee<int>();

            eString.Things = new List<string>() { "Phone", "Mousepad", "laptop", "Desk", "water bottle", "Mug", "Calculator", "Key Card" };
            eInt.Things = new List<int>() { 33, 333, 37, 3 };

            Console.Write("\nEach new employee is issued the following: ");
            int ii = eString.Things.Count;

            foreach (string thing in eString.Things)
            {
                Console.Write(thing);
                if (ii > 1)
                {
                    Console.Write("\n");
                }
                else
                {
                    Console.Write("\n\n");
                }
                ii--;
            }

            IQuittable eQuit = new Employee<string>();
            eQuit.Quit();

            Console.ReadLine();
        }
    }
}