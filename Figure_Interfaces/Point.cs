namespace Figure_Interfaces
{
    public class Point
    {
        public int X { get; set; }

        public int Y { get; set; }

        public char Name { get; set; } 

        public Point(int x, int y, char name)
        {
            X = x;
            Y = y;
            Name = name;
        }
    }
}
