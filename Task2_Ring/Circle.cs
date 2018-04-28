namespace ADO.NET_Task_2_b
{
    public class Circle
    {
        private double radius;
        public Circle(Point center, double radius)
        {
            Center = center;
            R = radius;
        }

        public double R
        {
            get => radius;
            set
            {
                if (value <= 0)
                    throw new System.Exception("Radius can't be less than zero.");
            }
        }
        public Point Center { get; set; }
    }
}