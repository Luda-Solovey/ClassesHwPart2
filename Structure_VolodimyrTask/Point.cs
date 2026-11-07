namespace Structure_VolodimyrTask
{
    public struct Point(int x, int y, string name, ConsoleColor consoleColor)
    {
        private int x = x;
        private int y = y;

        public int X => x;

        public int Y => y;
        private string name = name;
        private readonly ConsoleColor consoleColor = consoleColor;

        public void Draw()
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine($"Point {name}: ({X}, {Y})");
            Console.ResetColor();
        }

        public void Add(Point pointToAdd)
        {
            x += pointToAdd.x;
            y += pointToAdd.y;
            name += pointToAdd.name;
        }   
    }
}
