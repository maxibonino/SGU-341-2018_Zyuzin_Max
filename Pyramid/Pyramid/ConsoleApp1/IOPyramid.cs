using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace ConsoleApp1
{
    static class IOPyramid
    {
        #region Write File
        public static void Write(string FileName, Pyramid pyramid)
        {
            using (StreamWriter fileOut = new StreamWriter(FileName))
            {
                fileOut.WriteLine("Площадь основания {0}", pyramid.AreaBase);
                fileOut.WriteLine("Объём пирамиды {0}", pyramid.Volume);
            }
        }
        #endregion

        #region Read File 
        public static Tuple<IEnumerable<Point>, double> Read(string FileName)
        {
            using (StreamReader file = new StreamReader(FileName))
            {
                int AmountOfPoints = Pyramid.BaseNumber + 1;
                Point[] points = new Point[AmountOfPoints];
                for (int i = 0; i < AmountOfPoints; i++)
                {
                    string[] line = file.ReadLine().Split();

                    points[i] = new Point
                    {
                        X = Checker.Instance.ReadDouble(line[0]),
                        Y = Checker.Instance.ReadDouble(line[1]),
                        Z = Checker.Instance.ReadDouble(line[2])
                    };
                }

                double height = Checker.Instance.ReadDouble(file.ReadLine());
                return new Tuple<IEnumerable<Point>, double>(points, height);
            }
        }
        #endregion
    }
}