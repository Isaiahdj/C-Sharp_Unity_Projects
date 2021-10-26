using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int> { };
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("We are going to create a list of 10 numbers");
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
            listCreate:
                int userNum;
                int listNum = i + 1;
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("Please enter the "+listNum+" number to add to the list:     ");
                try
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    userNum = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter in a whole number");
                    goto listCreate;
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your number was to large please enter a different number");
                    goto listCreate;
                }
                numList.Add(userNum);
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Now We are going to pick a number and divide each number in the list by that number");
            Console.WriteLine();
        listDivide:
            try
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("Please enter in a number to divide the list by:     ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                int divideNum = Convert.ToInt32(Console.ReadLine());
                if (divideNum == 0) // Had to use an if becauase when dividing by zero it just gave me infinity instead of catching it
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Im sorry but we can't divide by zero so please enter a different number");
                    goto listDivide;
                }
                for (int i = 0; i < numList.Count; i++)
                {
                    double results = (double)numList[i] / divideNum;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(numList[i] + " divided by " + divideNum + " = ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(results);
                }
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a whole number");
                goto listDivide;
            }
            catch (OverflowException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Im sorry the number you chose was to large please enter a different number");
                goto listDivide;
            }
            Console.ReadLine();
        }
    }
}