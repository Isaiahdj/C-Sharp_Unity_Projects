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
            //create object 
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            //call method
            employee.SayName();
            IQuittable eQuit = new Employee();
            eQuit.Quit();
            Console.ReadLine();

            Employee employee1 = new Employee();
            employee1.FirstName = "Wayde";
            employee1.LastName = "Wats";
            employee1.eID = 333;

            Employee employee2 = new Employee();
            employee2.FirstName = "Barry";
            employee2.LastName = "Allen";
            employee2.eID = 257;

            employee1.SayName();
            employee2.SayName();

            bool eEquals = employee2 == employee1;

            Console.ReadLine();
        }
    }
}