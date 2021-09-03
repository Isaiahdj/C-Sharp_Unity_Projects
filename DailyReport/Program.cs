using System;


namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            // Header and title
            Console.ForegroundColor = ConsoleColor.Blue; //Changes console text color
            Console.WriteLine("The Tech Academy");
            Console.ForegroundColor = ConsoleColor.Cyan; // changing color again for contrast
            Console.WriteLine("Student Daily Report");
            Console.WriteLine(""); // added to create a space between this line and the questions

            // Question #1
            Console.ForegroundColor = ConsoleColor.Magenta; // this is the color for all questions
            Console.Write("What course are you on?:     "); // Used Write instead of WriteLine to put user text on the same line as question 
            Console.ForegroundColor = ConsoleColor.Green; // changed color here so when user types their answer is green
            string courseName = Console.ReadLine(); // creating a string variable containing the user input
            //Question #2
            Page:
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("What page number?:     ");
            Console.ForegroundColor = ConsoleColor.Green;
            try    //Using try catc to get correct user input
            {
                short pageNum = Convert.ToInt16(Console.ReadLine()); // Converting user input into a short for practice 
                //used short because it does not need to take up as much space as an integer
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a valid input!");
                goto Page;
            }

            //Question #3
        Helpwanted:
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Do you need help with anything? (Please answer \"true\" or \"false\"):     ");
            Console.ForegroundColor = ConsoleColor.Green;
            string h = Console.ReadLine();
            try     //Using try catc to get correct user input
            {
                bool helpNeeded = Convert.ToBoolean(h); // stored user input as a boolean
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a valid input!");
                goto Helpwanted;
            }
            
            //Question #4
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Were there any positive experiences you'd like to share? (please give specifics):     ");
            Console.ForegroundColor = ConsoleColor.Green;
            string posExper = Console.ReadLine(); // string variable
            //Question #5
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Is there any feedback you would like to provide? (please give specifics):     ");
            Console.ForegroundColor = ConsoleColor.Green;
            string Feedback = Console.ReadLine(); //string variable
            //Question # 6
            Hours:
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("How many hours did you study today?:     ");
            Console.ForegroundColor = ConsoleColor.Green;
            try     //Using try catc to get correct user input
            {
                float studyHrs = Convert.ToSingle(Console.ReadLine()); // used a float here so that user can enter in a decimal
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a valid input!");
                goto Hours;
            }

            // Closing message
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(""); // line to seperate the following text from the questions
            Console.WriteLine("Thank you for your answers an instructer will respond shortly.");
            Console.WriteLine("Have a great day");
            Console.ReadLine(); // put here to keep console open til user hits enter
        }
    }
}