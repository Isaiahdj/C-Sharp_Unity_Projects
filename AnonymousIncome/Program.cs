// Date:                    9/4/21
// Creater:                 Isaiah D. Johnson
// Description:             App made to collect user input from two different users,
//                          then take the input and calculate an anual wage for both
//                          users and then see who makes more per year.

using System;


namespace AnonymousIncome
{
    class Program
    {
        static void Main()
        {
            //Header
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("");

            // Person 1 info
            Console.ForegroundColor = ConsoleColor.DarkMagenta; // Dark magenta is going to be person 1's color
            Console.WriteLine("Person 1");
            Pay1:
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("How much do you get paid per hour?:    "); // Using write to have users input on the same line
            Console.ForegroundColor = ConsoleColor.Magenta; // When the user types it changes to a lighter color
            Console.Write("$"); // put this here to add a money sign to user input
            decimal p1Hr;
            try
            {
                p1Hr = Convert.ToDecimal(Console.ReadLine()); // Using a decimal because I am working with money
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a Decimal!");
                goto Pay1;
            }
            Hour1:
            Console.ForegroundColor = ConsoleColor.DarkMagenta; // Setting color back to user color
            Console.Write("How many hours do you work per week?:     ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            decimal p1Week;
            try
            {
                p1Week = Convert.ToDecimal(Console.ReadLine()); // Using decimal here to make math easier for later
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a Decimal!");
                goto Hour1;
            }
            Console.WriteLine(""); // Added space to seperat Person 1 from Person 2

            // Person 2 info
            Console.ForegroundColor = ConsoleColor.DarkGreen; // Dark green is Peson 2's color
            Console.WriteLine("Person 2");
            Pay2:
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("How much do you get paid per hour?:    ");
            Console.ForegroundColor = ConsoleColor.Green; // changed color to make user input a lighter color
            Console.Write("$");
            decimal p2Hr;
            try
            {
                p2Hr = Convert.ToDecimal(Console.ReadLine());
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a Decimal!");
                goto Pay2;
            }
            Hour2:
            Console.ForegroundColor = ConsoleColor.DarkGreen; // reverting back 2 user color
            Console.Write("How many hours do you work per week?:     ");
            Console.ForegroundColor = ConsoleColor.Green;
            decimal p2Week;
            try
            {
                p2Week = Convert.ToDecimal(Console.ReadLine());
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a Decimal!");
                goto Hour2;
            }
            Console.WriteLine(""); // added space between getting user inputs and anual salary

            // Calculations
            decimal p1Salary = (p1Hr * p1Week) * 52; // Using math to get Peson 1's anual salary
            decimal p2Salary = (p2Hr * p2Week) * 52; // Using math to get Peson 2's anual salary

            // Income display
            Console.ForegroundColor = ConsoleColor.DarkMagenta; // Setting color to person 1
            Console.Write("Person 1 your anual salary is: ");
            Console.ForegroundColor = ConsoleColor.Magenta; // Setting answer to a lighter color
            Console.WriteLine("$" + p1Salary.ToString());
            Console.ForegroundColor = ConsoleColor.DarkGreen; // Setting color to person 2
            Console.Write("Person 2 your anual salary is: ");
            Console.ForegroundColor = ConsoleColor.Green; // Setting answer to a lighter color
            Console.WriteLine("$" + p2Salary.ToString());
            Console.WriteLine(""); // added space between income display and highest income

            // Highest income
            bool highestSal = p1Salary > p2Salary; // Boolean to figure out who makes more per year
            if (highestSal == true) // If statement to make the write text apear in the write color
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta; // Changed to this color because person 1 has a higer anual income
                Console.WriteLine("Person 1 makes more money than Person 2"); // Displays if person 1 has higher income
            }
            else // If highestSal is false it runs this
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen; // Changed to this color because person 2 has a higer anual income
                Console.WriteLine("Person 2 makes more money than Person 1"); // Displays if person 1 has higher income
            }
            Console.ReadLine(); // this is here to keep console open til user presses enter
        }
    }
}
