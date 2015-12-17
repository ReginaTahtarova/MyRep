using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyUnitTest
{
    public class Class1
    {
        public static double[] Function(double a, double b)
        {
            var c = 0.0;
            if (a >= 0 && b >= 0 && a >= b)
            {
                c = a - b;
                return new[] { c };
            }
            else
                return new double[] { };
        }
    }
}