using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optionalParamater
{
    class Program
    {
        static void Main(string[] args)
        {
            optMath math = new optMath();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Please enter an integer");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            int userNum = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter a second integer (Optional)");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            string userIn = Console.ReadLine();
            
            if (userIn == "")
            {
                int ans = math.opMath(userNum);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Since you opted out of putting in a second number we gave you a second number of 3");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(userNum + " * 3 = ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(ans);
            }
            else
            {
                int userNum2 = Convert.ToInt32(userIn);
                int ans = math.opMath(userNum, userNum2);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Now we multiply your two numbers to get the results");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(userNum + " * " + userNum2 + " = ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(ans);


            }


            Console.ReadLine();
        }
    }
}