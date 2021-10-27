using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            voidMath math = new voidMath();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Im going to some math with numbers you have not seen yet press ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Enter ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("to start the program");
            Console.ReadLine();

            math.vMath(3, 13);

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Now Im going to do the same math with your numbers, press ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Enter ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("to begin");
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Please enter your first number: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Please enter your second number: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            int userNum2 = Convert.ToInt32(Console.ReadLine());
            math.vMath(userNum1, userNum2);


            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Press ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Enter ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("to terminate this program thank you have a nice day!");
            Console.ReadLine();
        }
    }
}