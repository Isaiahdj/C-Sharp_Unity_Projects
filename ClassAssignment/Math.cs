using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Math
    {
        public void mathMethod(int userNum)
        {
            double result = Convert.ToDouble(userNum) / 2;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Your number cut in half is: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(result);
        }


        public static int mathMethod(int userNum, int num)
        {
            int result = userNum * num;
            return result;
        }


        public void addition(int userNum,out int x)
        {          
            x = userNum + 13;
        }

    }
}