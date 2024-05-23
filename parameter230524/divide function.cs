using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameter230524
{
    internal class divide_function
    {

            public int dividefun(int x, int y, out int rem, out int que)
        {
            rem = x % y;
            que = x / y;
            return que;

        }
    }

}



