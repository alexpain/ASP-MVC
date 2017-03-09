using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculateAndConvert
{
    public class SqrtCalculate
    {
        
        private static double myPow(double a, int pow)
        {
            double result = 1;
            for (int i = 0; i < pow; i++) result *= a;
            return result;
        }

        public static double SqrtN(double n, double A, int accuracy, bool MathPow = false)
        {
            double eps = 0.0001;
            var x0 = A / n;
            var x1 = (1 / n) * ((n - 1) * x0 + A / (MathPow ? Math.Pow(x0, (int)n - 1) : myPow(x0, (int)n - 1)));

            while (Math.Abs(x1 - x0) > eps)
            {
                x0 = x1;
                x1 = (1 / n) * ((n - 1) * x0 + A / (MathPow ? Math.Pow(x0, (int)n - 1) : myPow(x0, (int)n - 1)));
            }

            return Math.Round(x1, accuracy);
        }
    }
}