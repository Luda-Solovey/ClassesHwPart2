namespace Structure_VolodimyrTask
{
    public struct Point(int x, int y, string name, ConsoleColor consoleColor)
    {
        private int x = x;
        private int y = y;

        public readonly int X => x;

        public readonly int Y => y;
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
