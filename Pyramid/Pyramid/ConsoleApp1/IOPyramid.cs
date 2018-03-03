using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public static void Read(string FileName, ref Pyramid pyramid)
        {
            using (StreamReader file = new StreamReader(FileName))
            {
                Point[] baseOfPyramid = new Point[Pyramid.BaseNumber];

                for (int i = 0; i < Pyramid.BaseNumber; i++)
                {
                    string[] line = file.ReadLine().Split();


                    baseOfPyramid[i] = new Point
                    {
                        x = Cheker.ReadDouble(line[0]),
                        y = Cheker.ReadDouble(line[1]),
                        z = Cheker.ReadDouble(line[2])
                    };
                }
               
                string[] lineApex = file.ReadLine().Split();

                Point apex = new Point
                {
                    x = Cheker.ReadDouble(lineApex[0]),
                    y = Cheker.ReadDouble(lineApex[1]),
                    z = Cheker.ReadDouble(lineApex[2])
                };

                double height = Cheker.ReadDouble(file.ReadLine());

                pyramid = new Pyramid(baseOfPyramid, apex, height);
            }
        }
        #endregion
    }
}
