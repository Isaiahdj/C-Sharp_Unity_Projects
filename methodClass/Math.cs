using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodClass
{
    public class Math
    {

        public static int num;
        public static void Squared()
        {
            long square = num * num;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Your number squared = ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(square);
            Console.WriteLine();
        }

        public static void Half()
        {
            double half = (double)num / 2;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Your number cut in half = ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(half);
            Console.WriteLine();
        }

        public static void Doubled()
        {
            long doubled = num * 2;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Your number doubled = ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(doubled);
        }

    }
}
