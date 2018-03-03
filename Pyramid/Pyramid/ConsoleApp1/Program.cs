using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pyramid pyramid = new Pyramid();

            IOPyramid.Read("pyramid - origin.txt", ref pyramid);

            pyramid.ChangePointOfBase(new Point { x = 2.5, y = 3.2, z = 4.5 }, 0);

            IOPyramid.Write("out.txt", pyramid);
        }
    }
}