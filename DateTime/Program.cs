using System;

namespace DateTimeAssingment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("The current time is ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(DateTime.Now);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nPlease enter a number: ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            double userNum = Convert.ToDouble(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nIn ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(userNum);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" hour(s), the time will be: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(DateTime.Now.AddHours(userNum));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.ReadLine();

        }
    }
}