namespace Figure_Interfaces
{
    //Метод ShowInfo() виводить в один рядок: назву фігури, сторони, площу та периметр.
    public class Rectangle(Point a, Point b, Point c) : Figure(a, b, c), IDrawable, IPrintable
    {
        private double perimetr;

        public override string Name => "Rectangle";

        public Point A { get; } = a;
        public Point B { get; } = b;
        public Point C { get; } = c;

        public double Side1 => LengthSide(points[0], points[1]);

        public double Side2 => LengthSide(points[1], points[2]);

        public double Side3 => LengthSide(points[2], points[0]);

        public void Draw(ConsoleColor backColor, ConsoleColor foreColor)
        {
            //int hight = 5; //(int)Math.Round(Math.Max(Side1, Side2));

            Console.BackgroundColor = backColor;
            Console.ForegroundColor = foreColor;

            Console.WriteLine($"{Name}:");

            //прямокутник
            //for (int row = 0; row < hight; row++)
            //{
            //    for (int column = 0; column < hight; column++)
            //    {
            //        Console.Write("*");
            //    }
            //        Console.Write("\n");
            //}

            //for (int row = 0; row < hight; row++)
            //{
            //    for (int column = 0; column <= row; column++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.Write("\n");
            //}

            //---------------------------------
            int height = 5;

            //for (int row = 1; row <= height; row++)
            //{

            //    // Пробіли
            //    for (int space = 1; space <= height - row; space++)
            //    {
            //        Console.Write(" ");
            //    }

            //    // Зірочки
            //    for (int star = 1; star <= row; star++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            for (int row = 1; row <= height; row++)
            {
                for (int column = 1; column <= row; column++)
                {
                    if (column == 1 ||
                        column == row ||
                        row == height)

                    {
                        Console.Write("*");
                    }
                    else
                    { 
                        Console.Write(" "); 
                    }
                }
                    Console.WriteLine();
            }
            

            //Console.WriteLine($"Triengle for now *************************");

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
