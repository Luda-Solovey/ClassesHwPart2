namespace Figure_Interfaces
{
    public abstract class Figure
    {
        public virtual string? Name { get; }
        protected readonly Point[] points;
        protected Figure(Point A, Point B, Point C)
        {
            points = [A, B, C];
        }

        protected Figure(Point A, Point B, Point C, Point D)
        {
            points = [A, B, C, D];
        }

        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            points = [A, B, C, D, E];
        }

        public double LengthSide(Point point1, Point point2)
        {
            double lenghSide = Math.Sqrt(
                Math.Pow(point2.X - point1.X, 2) +
                Math.Pow(point2.Y - point1.Y, 2));

            return lenghSide;
        }
        public virtual double GetPerimetr()
        {
            double perimeter = 0;

            perimeter += LengthSide(points[0], points[1]);
            perimeter += LengthSide(points[1], points[2]);

            if (points.Length > 3)
            {
                perimeter += LengthSide(points[2], points[3]);

                if (points.Length > 4)
                {
                    perimeter += LengthSide(points[3], points[4]);
                    perimeter += LengthSide(points[4], points[0]);
                }
                else
                {
                    perimeter += LengthSide(points[3], points[0]);
                }
            }
            else
            {
                perimeter += LengthSide(points[2], points[0]);
            }

            return perimeter;
        }

        public abstract double GetArea();
    }
}
