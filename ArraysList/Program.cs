//Name: Isaiah Daniel Johnson
//Date: 9/6/21
//Description: Creating several arrays with the user and then having the user pick a string and number at a specific indexies
using System;
using System.Collections.Generic;

namespace Array_List
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = new string[4];   //Setting an array of strings with the length of 4
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Intro to C# Arrays and lists");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Im going to ask you for strings that will be stored in an array");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Please enter in your first string:     ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            stringArray[0] = Console.ReadLine();    //setting users input to index 0 in the string array
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Please enter some more text to add to this array:     ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            stringArray[1] = Console.ReadLine();    //setting users input to index 1 in the string array
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Please enter in another string:     ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            stringArray[2] = Console.ReadLine();    //setting users input to index 2 in the string array
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Please enter one last string to complete our array:     ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            stringArray[3] = Console.ReadLine();    //setting users input to index 3 in the string array
            Console.WriteLine();    //added to add a space before the next question

        Index1:
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Please enter in a number from 0 to 3 and i will fetch the data in your array at that index:     ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            int index = Convert.ToInt32(Console.ReadLine());
            if (index > 3 || index < 0)     //Validtes users input
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a valid number");
                goto Index1;
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Now fetching that index please press enter to veiw your selection");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(stringArray[index]);  //displays the string at the index that the user picked

            Console.WriteLine();
            Console.WriteLine();
            int[] numArray = new int[4];    //instatiating my numArray
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Now we are going to creat an array of integers");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Please enter in your first number:     ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            numArray[0] = Convert.ToInt32(Console.ReadLine());  //setting users input to numArray[0]
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Please enter in your second number:     ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            numArray[1] = Convert.ToInt32(Console.ReadLine());  //setting users input to numArray[1]
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Please enter in your third number:     ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            numArray[2] = Convert.ToInt32(Console.ReadLine());  //setting users input to numArray[2]
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Please enter in your finale number:     ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            numArray[3] = Convert.ToInt32(Console.ReadLine());  //setting users input ti=o numArray[3]
            Console.WriteLine();    //put here for astetic reasons

        Index2:
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Please enter in a number from 0 to 3 and i will fetch the data in your array at that index:     ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            index = Convert.ToInt32(Console.ReadLine());
            if (index > 3 || index < 0) //validates users input
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a valid number");
                goto Index2;
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Now fetching that index please press enter to veiw your selection");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(numArray[index]); //displays the number in the array at the user specified index

            Console.WriteLine();
            Console.WriteLine();    //adding spaces before next section
            List<string> stringList = new List<string>();   //istantiating stringList which is a list of stings
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Now we are going to create a list which techinqually we can make it what ever length but im going to constrict it to a length of 4");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Please enter a string:     ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            stringList.Add(Console.ReadLine()); //sets user input as stringList[0]
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Please enter some more text:     ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            stringList.Add(Console.ReadLine()); //sets user input as stringList[1]
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Please enter in some words:     ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            stringList.Add(Console.ReadLine()); //sets user input as stringList[2]
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Please enter a finale string:     ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            stringList.Add(Console.ReadLine()); //sets user input as stringList[3]
            Console.WriteLine();

        Index3:
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Please enter in a number from 0 to 3 and i will fetch the data in your list at that index:     ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            index = Convert.ToInt32(Console.ReadLine());
            if (index > 3 || index < 0) //validating users input
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a valid number");
                goto Index3;
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Now fetching that index please press enter to veiw your selection");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(stringList[index]);
            Console.ReadLine();
        }
    }
}