namespace ADO.NET_Task_2_b
{
    public class Circle
    {
        public Circle(Point center, double radius)
        {
            Center = center;
            R = radius;
        }

        public double R { get; set; }
        public Point Center { get; set; }
    }
}