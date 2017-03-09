using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_T1
{
    public class ConvertBinary
    {
        public static String getBinary(int n)
        {
            return Convert.ToString(n, 2);
        }
    }
}