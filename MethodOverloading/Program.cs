using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOverload math = new MathOverload();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\nEnter an integer you would like multiplied by 13: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            int valInt = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n{0}*13 = {1}", valInt, math.Calc(valInt));

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\nEnter a decimal you would like multiplied by 3: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            decimal valDec = Convert.ToDecimal(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n{0}*3 = {1}", valDec, math.Calc(valDec));

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\nEnter a number you would like multiplied by 33: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            string valStr = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n{0}*33 = {1}", valStr, math.Calc(valStr));


        }
    }
}