using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class Checker
    {

        public static double ReadDouble(string num)
        {
            double result;

            if (!double.TryParse(num, out result))
                throw new Exception("Read Error");

            return result;
        }
    }
}
