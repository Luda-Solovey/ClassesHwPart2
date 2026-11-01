namespace Figure_Interfaces
{
    //Метод ShowInfo() виводить в один рядок: назву фігури, сторони, площу та периметр.
    public class Rectangle(Point a, Point b, Point c) : Figure(a, b, c), IDrawable, IPrintable
    {
        private double perimetr;

        public override string  Name => "Rectangle";

        public Point A { get; } = a;
        public Point B { get; } = b;
        public Point C { get; } = c;

        public double Side1 => LengthSide(points[0], points[1]);

        public double Side2 => LengthSide(points[1], points[2]);

        public double Side3 => LengthSide(points[2], points[0]);

        public void Draw(ConsoleColor backColor, ConsoleColor foreColor)
        {
            Console.BackgroundColor = backColor;
            Console.ForegroundColor = foreColor;

            Console.WriteLine($"{Name}:");
            Console.WriteLine("Triengle for now *************************");

            Console.ResetColor();
        }

        public override double GetPerimetr()
        {
            double perimeter = 0;
            perimeter += LengthSide(points[0], points[1]);
            perimeter += LengthSide(points[1], points[2]);
            perimeter += LengthSide(points[2], points[0]);

            this.perimetr = perimeter;

            return perimeter;
        }
        public override double GetArea()
        {
            double area;

            area = Math.Sqrt(perimetr * (perimetr - Side1) * (perimetr - Side2) * (perimetr - Side3));

            return area;
        }

        public void Print()
        {
            Console.WriteLine("Triengle for now ************************* standart console color");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Figure: {Name}, side AB = {Side1}, side BC = {Side2}, side CA = {Side3}, perimetr = {GetPerimetr()}, area = {GetArea()}");

        }
    }
}
