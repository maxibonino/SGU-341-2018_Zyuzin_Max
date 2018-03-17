namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = IOPyramid.Read("pyramid - origin.txt");
            Pyramid pyramid = new Pyramid(data);
            pyramid.ChangePointOfBase(new Point { X = 2.5, Y = 3.2, Z = 4.5 }, 0);
            IOPyramid.Write("out.txt", pyramid);
        }
    }
}