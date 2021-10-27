using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Im going to ask you for a number then I will do some math on that number and print it out to you");
        number:
            try
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("please enter in a number:     ");
                Console.ForegroundColor = ConsoleColor.Green;
                Math.num = Convert.ToInt32(Console.ReadLine());
            }
            catch (OverflowException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your number is way to big please enter a different number");
                goto number;
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a whole number");
                goto number;
            }
            Console.WriteLine();
            Math.Squared();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Press enter to do more math on your number");
            Console.ReadLine();
            Math.Half();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Press enter to do math on your number one last time");
            Console.ReadLine();
            Math.Doubled();
            Console.ReadLine();
        }
    }
}