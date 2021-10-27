using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optionalParamater
{
    class optMath
    {
        public int opMath(int userNum, int userNum2 = 3)
        {
            int ans = userNum * userNum2; //Operator for answer1
            return ans;
        }

    }
}