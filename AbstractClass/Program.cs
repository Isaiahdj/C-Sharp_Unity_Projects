using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee1 = new Employee<string>() { eID = 33, FirstName = "Wayde", LastName = "Watts" };
            Employee<string> employee2 = new Employee<string>() { eID = 07, FirstName = "Barry", LastName = "Allen" };
            Employee<string> employee3 = new Employee<string>() { eID = 13, FirstName = "Steve", LastName = "Rodgers" };
            Employee<string> employee4 = new Employee<string>() { eID = 09, FirstName = "Tony", LastName = "Stark" };
            Employee<string> employee5 = new Employee<string>() { eID = 05, FirstName = "Bruce", LastName = "Wayne" };
            Employee<string> employee6 = new Employee<string>() { eID = 27, FirstName = "Sam", LastName = "Wilson" };
            Employee<string> employee7 = new Employee<string>() { eID = 53, FirstName = "T'Challa", LastName = "Udaku" };
            Employee<string> employee8 = new Employee<string>() { eID = 03, FirstName = "Scott", LastName = "Lang" };
            Employee<string> employee9 = new Employee<string>() { eID = 11, FirstName = "Bruce", LastName = "Banner" };
            Employee<string> employee10 = new Employee<string>() { eID = 23, FirstName = "Steven", LastName = "Strange" };

            List<Employee<string>> employees = new List<Employee<string>>() 
            { employee1, employee2, employee3, employee4, employee5, employee6, employee7, employee8, employee9, employee10 };

            List<Employee<string>> eBruce = new List<Employee<string>>();

            foreach (Employee<string> employee in employees)
            {
                Console.WriteLine("{0} {1} {2}", employee.eID, employee.FirstName, employee.LastName);
            }


            foreach (Employee<string> employee in employees)
            {
                if (employee.FirstName == "Bruce")
                {
                    eBruce.Add(employee);
                }
            }

            Console.WriteLine("\nEach 'Bruce' from new list:");
            foreach (Employee<string> employee in eBruce)
            {
                Console.WriteLine("{0} {1}", employee.FirstName, employee.LastName);
            }

          

            Console.WriteLine("\nEvery employee with an ID above 13:");
            List<Employee<string>> employee13 = employees.Where(x => x.eID > 13).ToList();
            foreach (Employee<string> employee in employee13)
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

            //create object 
            //Employee employee = new Employee();
            //employee.FirstName = "Sample";
            //employee.LastName = "Student";
            //call method
            //employee.SayName();
            //Console.ReadLine();

            //Employee employee1 = new Employee();
            //employee1.FirstName = "Wayde";
            //employee1.LastName = "Wats";
            //employee1.eID = 333;

            //Employee employee2 = new Employee();
            //employee2.FirstName = "Barry";
            //employee2.LastName = "Allen";
            //employee2.eID = 257;

            //employee1.SayName();
            //employee2.SayName();

            //bool eEquals = employee2 == employee1;

            Console.ReadLine();
        }
    }
}