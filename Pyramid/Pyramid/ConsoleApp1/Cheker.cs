using System;

namespace ConsoleApp1
{
    public class Checker
    {
        private Checker()
        { }

        static Checker()
        {
            Instance = new Checker();
        }

        public static Checker Instance;

        public double ReadDouble(string num)
        {
            double result;

            if (!double.TryParse(num, out result))
            {
                throw new Exception("Read Error");
            }

            return result;
        }
    }
}
