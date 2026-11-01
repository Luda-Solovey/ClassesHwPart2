namespace Figure_Interfaces
{
    public interface IDrawable
    {
        public string Name { get; }

        void Draw(ConsoleColor backColor, ConsoleColor foreColor);

        void ShowInfo();
    }
}
