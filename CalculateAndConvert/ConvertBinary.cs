using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculateAndConvert
{
    public class ConvertBinary
    {
        public static String getBinary(int n)
        {
            return Convert.ToString(n, 2);
        }
    }
}