using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itteration
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameArray = { "My name is ", "It has always been ", "And always will be ", "", "Hello " };
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Please enter your name:     ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string name = Console.ReadLine();
            for (int i = 0; i < nameArray.Length; i++)
            {
                nameArray[i] = nameArray[i] + name;
            }
            foreach (string str in nameArray)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(str);
            }
            Console.WriteLine();

            //for (int i = 1; i != 0; i++)
            //{
            //    Console.WriteLine("i = " + i);
            //}

            Console.WriteLine("press enter to count to 13");
            Console.ReadLine();
            for (int i = 1; i <= 13; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

        Count_To:
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(" Now you give me a positive number between 2 and 100:     ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            int countTo = Convert.ToInt32(Console.ReadLine());
            if (countTo > 100 || countTo < 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a valid number");
                goto Count_To;
            }
            List<string> colors = new List<string> { "Blue", "Green", "Red", "Purple", "Pink" };
            int col = 0;
            for (int i = 1; i <= countTo; i++)
            {
                if (col == colors.Count)
                {
                    col = 0;
                }
                if (col == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (col == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (col == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (col == 3)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                col++;
                Console.WriteLine(i);
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Enter a color and i will check to see if it is in my list:     ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string colorSearch = Console.ReadLine();
            int match = 0;
            for (int i = 0; i < colors.Count; i++)
            {
                if (colorSearch.ToLower() == colors[i].ToLower())
                {
                    Console.Write("I found that exact color in the list at ");

                    if (colorSearch.ToLower() == "blue")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else if (colorSearch.ToLower() == "green")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (colorSearch.ToLower() == "red")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (colorSearch.ToLower() == "purple")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }
                    match++;
                    Console.WriteLine("index " + i);
                    break;
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            if (match == 0)
            {
                Console.WriteLine("im sorry but i could not find that color in my list");
            }

            List<string> colors2 = new List<string> { "Blue", "Green", "Blue", "Red", "Purple", "Blue", "Pink", "Green", "Purple", "Red", "Blue", "Purple" };
            Console.Write("Enter a color and i will check to see if it is in my list:     ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            colorSearch = Console.ReadLine();
            List<int> indexs = new List<int> { };
            match = 0;
            for (int i = 0; i < colors2.Count; i++)
            {
                if (colorSearch.ToLower() == colors2[i].ToLower())
                {
                    indexs.Add(i);
                    match++;
                }
            }
            if (match == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("im sorry but i could not find that color in my list");
            }
            else
            {
                Console.WriteLine("I found that color in the list in " + indexs.Count + " indexes:");
                if (colorSearch.ToLower() == "blue")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (colorSearch.ToLower() == "green")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (colorSearch.ToLower() == "red")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (colorSearch.ToLower() == "purple")
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                foreach (int index in indexs)
                {
                    Console.WriteLine("Index " + index);
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine();
            Console.WriteLine("Press enter to run the last for loop");
            Console.ReadLine();
            int ii = 0;
            foreach (string color in colors2)
            {
                int multiples = 0;
                for (int i = 0; i < ii; i++)
                {
                    if (colors2[ii] == colors2[i])
                    {
                        multiples++;
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Here is the color at index " + ii + " " + colors2[ii] + " ");
                if (multiples > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("So far this color has shown up " + multiples + " other times in this list");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("this is the only time this color has shown up so far in the list");
                }
                ii++;
            }
            Console.ReadLine();
        }
    }
}
