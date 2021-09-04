
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int packNum;
            Console.ForegroundColor = ConsoleColor.Blue;    //changing text color to blue when console is making a statement
            Console.WriteLine("Welcome to the package express. Please follow the instructions below \n");
        EnterWeight:   
            Console.ForegroundColor = ConsoleColor.Cyan;    // changing text color for when console is asking a question
            Console.Write("Please enter in your packages weight:\t");
            Console.ForegroundColor = ConsoleColor.Yellow;  //Changing text color for when user is typing
            string userString = Console.ReadLine(); //setting users input
            Console.ForegroundColor = ConsoleColor.Red; // changing text color to red for if any exception is thrown
            try
            {
                int userNum = Convert.ToInt16(userString);  //trying to convert the string to an integer
            }
            catch (OverflowException)   //this gets thrown if the user enters an unreasonbly big number
            {
                Console.WriteLine("Your Package is far to heavy please try a different package");
                goto EnterWeight;
            }
            catch (FormatException) // this gets thrown if the user did not enter a number
            {
                Console.WriteLine("Please enter a whole number greater then or equal to 0");
                goto EnterWeight;
            }
            catch (Exception)   //this gets thrown if something else goes wrong
            {
                Console.WriteLine("Sorry something went wrong please try again");
                goto EnterWeight;
            }

            packNum = Convert.ToInt16(userString);

            if (packNum > 50)   // if the package is to heavy it ends the program
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day");
                goto End;
            }

        EnterWidth:
            Console.ForegroundColor = ConsoleColor.Cyan;    //question color
            Console.Write("Please enter the package width:\t\t");
            Console.ForegroundColor = ConsoleColor.Yellow;  //input color
            string widthString = Console.ReadLine();    // sets user input to a string
            Console.ForegroundColor = ConsoleColor.Red; //error color
            try
            {
                int userNum = Convert.ToInt16(widthString); //trys to convert the string to an integer
            }
            catch (OverflowException)   //thrown if # is far to big
            {
                Console.WriteLine("Your Package is far to wide please try a different package width");
                goto EnterWidth;
            }
            catch (FormatException) //thrown if user did not enter a #
            {
                Console.WriteLine("Please enter a whole number greater then or equal to 0");
                goto EnterWidth;
            }
            catch (Exception)   //thrown if there was an unexpected error
            {
                Console.WriteLine("Sorry something went wrong please try again");
                goto EnterWidth;
            }

        EnterHeight:
            Console.ForegroundColor = ConsoleColor.Cyan;    //question color
            Console.Write("Please enter the package height:\t");
            Console.ForegroundColor = ConsoleColor.Yellow;  //input color
            string heightString = Console.ReadLine();   //setting user input to string
            Console.ForegroundColor = ConsoleColor.Red; //error color
            try
            {
                int userNum = Convert.ToInt16(heightString);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Your Package is far to tall please try a different package height");
                goto EnterHeight;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a whole number greater then or equal to 0");
                goto EnterHeight;
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry something went wrong please try again");
                goto EnterHeight;
            }

        EnterLength:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Please enter the package length:\t");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string lengthString = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            try
            {
                int userNum = Convert.ToInt16(lengthString);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Your Package is far to long please try a different package length");
                goto EnterLength;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a whole number greater then or equal to 0");
                goto EnterLength;
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry something went wrong please try again");
                goto EnterLength;
            }

            int width = Convert.ToInt16(widthString);
            int height = Convert.ToInt16(heightString);
            int length = Convert.ToInt16(lengthString);
            int dimensions = width + height + length;   //calculating the dimensions

            if (dimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day");
                goto End;
            }
            decimal Quote = (width * height * length * packNum) / 100;  //calculating cost if the package can ship
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Blue;    //statement color
            Console.Write("To ship this package it would cost ");
            Console.ForegroundColor = ConsoleColor.Green;   //setting text color to green for the price
            Console.WriteLine("${0}", Quote);
        End:
            Console.ReadLine();
        }
    }
}
