namespace Figure_Interfaces
{
    public class Cat : Animal, IPrintable, IDrawable
    {
        public Cat(string name, string breed, float size, float weight)
            : base(name, breed, size, weight)
        {
        }

        public void Draw(ConsoleColor backColor, ConsoleColor foreColor)
        {
            Console.BackgroundColor = backColor;
            Console.ForegroundColor = foreColor;

            Console.WriteLine($"Cat {Name}:");
            Console.WriteLine("Colored cat`s figure *************************");

            Console.ResetColor();
        }

        public void Print()
        {
            Console.WriteLine($"Here has to be cat`s figure");
        }

        void IPrintable.ShowInfo()
        {
            Console.WriteLine($"Cat {Name}, breed {Breed}");
        }

        void IDrawable.ShowInfo()
        {
            Console.WriteLine($" Breed {Breed}, size {Size}, weight {Weight}");
        }
    }
}
