// Date:                    9/4/21
// Creator:                 Isaiah D. Johnson
// Discription:             Application that asks the user some questions then
//                          using their input determining if they qualified for
//                          car insurance

using System;


namespace Car_Insurance
{
    class Program
    {
        static void Main()
        {
            // Header
            Console.ForegroundColor = ConsoleColor.Blue; // Header color blue
            Console.WriteLine("Check to see if you are qualified fo car insurance");
            Console.WriteLine(""); // added spacing to seperate header from questions

            // Questions
            Console.ForegroundColor = ConsoleColor.Cyan; // set this color for when console is not asking questions or providing answer
            Console.WriteLine("Im going to ask a few questions to detirmine if you meet our qualifications");
            
            //************************** AGE SECTION ************************************************
            Age:
            Console.ForegroundColor = ConsoleColor.DarkMagenta; // this color is the color of all the questions
            Console.Write("How old are you?:     ");
            Console.ForegroundColor = ConsoleColor.Magenta; // This is the color when the user types anything
            short age;
            try
            {
                age = Convert.ToInt16(Console.ReadLine()); // Using short because nobody is old enough to need an int worth of memory
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red; // setting color to red because user done messed up
                Console.WriteLine("Please enter a valid Age");
                goto Age;
            }
            
            //************************** DUI SECTION *************************************************
            bool DUI = true; // defining DUI so that it can be changed in the while loop if needed
            while (true) // this loop is used to verify user input to the next question
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta; // question color
                Console.Write("Have you ever had a DUI? (please enter \"yes or \"no ):     ");
                Console.ForegroundColor = ConsoleColor.Magenta; // User color
                string dui = Console.ReadLine(); // defining user input as small dui to use locally in the while loop
                if (dui == "yes" || dui == "no") // this if statement is used to determine if the user entered a valid input
                {
                    if (dui == "yes")
                    {
                        DUI = false; // Sets the universal variable of DUI to false
                    }
                    else
                    {
                        DUI = true; // Sets the universal variable of DUI to false
                    }
                    break; // ends the while loop to move to next question
                }
                else // if input did not meet the if statement requirements do the following
                {
                    Console.ForegroundColor = ConsoleColor.Red; // setting color to red because user done messed up
                    Console.WriteLine("Please try again and enter a valid input (no caps)"); // message to user telling them they done did wrong
                } // goes back through while loop till user gets it right
            }

            //******************************** SPEED SECTION ************************************************
            Speed:
            Console.ForegroundColor = ConsoleColor.DarkMagenta; // question color
            Console.Write("How many speeding tickets do you have?:     ");
            Console.ForegroundColor = ConsoleColor.Magenta; // user color
            short Speed;
            try
            {
                Speed = Convert.ToInt16(Console.ReadLine()); // used a short becauase nobody should have more then 16 bytes worth of speeding tickets
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red; // setting color to red because user done messed up
                Console.WriteLine("Please enter a valid number of tickets");
                goto Speed;
            }
            Console.WriteLine(""); // added space to seperate questions from processing dialog

            //******************************** Processing dialog **************************************************
            Console.ForegroundColor = ConsoleColor.Cyan; // console color
            Console.WriteLine("Now checking your answers with our qualifications ....");
            Console.WriteLine("please press enter to see if you qualified"); // instructing user
            Console.ReadLine(); // forces user to press enter to see results

            //**************************************** Results ****************************************************
            if (age > 15 && DUI == true && Speed <= 3) // if statement to tell user if they qualified
            {
                Console.ForegroundColor = ConsoleColor.Green; // green for they qualified
                Console.WriteLine("Congratulations you have qualified for car insurance");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red; // red for they failed to meet requirments
                Console.WriteLine("Sorry you did not meet our qualifications so we can not provide you with car insurance");
            }
            Console.ReadLine(); // keeps console open till user presses enter
        }
    }
}