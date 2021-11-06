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
            Console.ReadLine();
        }
    }
}