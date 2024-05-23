using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameter230524
{
    internal class Triangle
    {
        public double triareacalculator(int s1, int s2, int s3, out double area, out double perarea)
        {
            int s = s1 + s2 + s3 / 2;
            area = Math.Sqrt( (s * (s - s1) * (s - s2) * (s - s3) ) );

            perarea = s1 + s2 + s3;
            return area;
        }
    }
} 
