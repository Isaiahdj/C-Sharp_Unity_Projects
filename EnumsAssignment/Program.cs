using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            dayEnter:
            try
            {   
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("Please enter the current day of the week: ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                weekDays day = (weekDays)Enum.Parse(typeof(weekDays), Console.ReadLine(), true);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The Day of the week today is {0}", day.ToString());
            }
            catch (ArgumentException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nPlease enter an actual day.\n");
                goto dayEnter;
            }
            Console.ReadLine();
        }


    }
    public enum weekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}