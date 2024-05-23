using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameter230524
{
    internal class Factorial
    {
        public int calculatefactrorial(int num, out int fact)
        {
            fact = 1;

            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}
