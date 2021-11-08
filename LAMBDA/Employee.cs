using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMBDA
{
    public class Employee<T> : Person, IQuittable
    {
        public int eID { get; set; }
        public List<T> Things;

        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }

        public void Quit()
        {
            Console.WriteLine("This employee quit");
        }

        public static bool operator == (Employee<T> one, Employee<T>
            two)
        {
            if (one.eID == two.eID)
            {
                Console.WriteLine("The ID's are the same");
                return true;
            }
            else
            {
                Console.WriteLine("The ID's are different.");
                return false;
            }

        }

        public static bool operator != (Employee<T> one, Employee<T> two)
        {
            if (one.eID == two.eID)
            {
                Console.WriteLine("The ID's are the same");
                return false;
            }
            else
            {
                Console.WriteLine("The ID's are different.");
                return true;
            }
        }
    }
}