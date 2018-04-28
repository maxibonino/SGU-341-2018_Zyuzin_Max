using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ADO.NET_Task_2_b
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            Ring ring = new Ring(new Circle(new Point(3.4, 3.8), 10), 3.09);

            Console.WriteLine(ring);
        }
    }
}
