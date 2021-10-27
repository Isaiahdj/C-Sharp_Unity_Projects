using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOverloading

{
    class MathOverload
    {
        public int Calc(int val)
        {
            return val * 13;
        }

        public int Calc(decimal val)
        {
            return Convert.ToInt32(val * 3);
        }

        public int Calc(string val)
        {
            int valNum = Convert.ToInt32(val);
            return valNum * 33;
        }
    }
}