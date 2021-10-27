using System;
using System.Collections.Generic;
using System.Text;

namespace voidMethod
{
    class voidMath
    {
        public void vMath(int val1, int val2)
        {
            // Perform the square operation on the first value
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nThe first value {0} multiplied by 3 is {1}", val1, val1 * 3);
            // Output the second value
            Console.WriteLine("\nThe second value is {0}", val2);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}