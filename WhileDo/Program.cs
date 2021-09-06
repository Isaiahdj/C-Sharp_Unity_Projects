//Name: Isaiah Daniel Johnson
//Date: 9/6/21
//Description: made a guessing game that promptss the user to guess a number between 1 and 10
//             it then processes the users input using while loops and a do while loop.

using System;


namespace While_and_do
{
    class Program
    {
        static void Main()
        {
            // setting two universal variaables
            bool Again = false; // this gets used in one of the loops
            int i = 1; // this gets used in a later loop
            int g = 1;

            // Starting statement
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("We are going to play a simple game all you have to do is guess a number");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Oh before I forget you are trapped til you get the number correct have fun ...");
            Console.WriteLine("press enter to try your luck");
            Console.ReadLine();

            // Do while loop
            do
            {
                bool rightNum = false; // Setting rightNum to false to start the next loop

                // Right Number loop
                while (!rightNum) // determines if your number is the correct number and restarts the game
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(""); // added space between last round and the start of the new round
                    Console.WriteLine("Round " + i.ToString()); // i will tell you what number of round it is
                    Console.WriteLine(""); // added space between this and the number guess
                    int ranNum = new Random().Next(1, 11); // sets the number to guess between 1 and 10
                    int userNum = 1; // sets a variable to use later

                    // Validating loop
                    while (true) // loop for determining if user entered a valid entry
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write("Please guess a number between 1 and 10:     ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        int number = Convert.ToInt32(Console.ReadLine());

                        // determines if number is valid
                        if (number >= 1 && number <= 10)
                        {
                            userNum = number;
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Please enter a valid number");
                        } // goes back and ask them to pick a number again
                    }

                    // determines if they got the number right
                    if (userNum == ranNum)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have guessed the right number");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You are free to go or go back in and try again up to you");

                        // Checks to see if user answered yes or no
                        while (true)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("Want to go again (\"yes or \"no):     ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            string again = Console.ReadLine();


                            if (again == "yes")
                            {
                                i = 1;
                                g++;
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("");
                                Console.WriteLine("resetting ...");
                                Console.WriteLine("Ok all prepared and ready for a new game try to escape faster this time , just press enter");
                                Console.ReadLine();
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Game " + g.ToString());
                                Again = true;
                                break;
                            }
                            else if (again == "no")
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Understood thanks for playing");
                                Again = false;
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Please enter a valid input and try again (no caps)");
                            }
                        }

                        rightNum = true;
                    }

                    else
                    {
                        i++;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You Guessed wrong so you failed to escape");
                        Console.WriteLine("forcing you to go again ....");
                        Console.WriteLine("press enter");
                        Console.ReadLine();
                    }
                }
            }

            while (Again == true);
            Console.ReadLine();
        }
    }
}
