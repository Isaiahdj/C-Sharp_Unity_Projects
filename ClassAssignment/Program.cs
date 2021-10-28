using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Please input a number: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            int userNum = Convert.ToInt32(Console.ReadLine());
            math.mathMethod(userNum);


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\nPress ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("to do another math operation on your number");
            Console.ReadLine();


            int x;
            math.addition(userNum, out x);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Your number plus 13 is: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(x);


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\nPress ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("to do another math operation on your number");
            Console.ReadLine();


            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Your number multipied by 3 is: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Math.mathMethod(userNum, 3));


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\nPress ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("to do another math operation on your number");
            Console.ReadLine();


            int square = mathStatic.Squared(userNum);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Your number squared is: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(square);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\nPress ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Enter ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("to terminate this program, thank you have a nice day");
            Console.ReadLine();

        }
    }
}
