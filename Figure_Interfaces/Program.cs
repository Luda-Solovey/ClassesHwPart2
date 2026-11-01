namespace Figure_Interfaces
{
    public class Program
    {
        static void Main()
        {
            Point point1 = new(2, 5, 'A');
            Point point2 = new(6, 3, 'B');
            Point point3 = new(3, 2, 'C');

            Rectangle triengle = new Rectangle(point1, point2, point3);
            triengle.ShowInfo();
            triengle.Draw(ConsoleColor.DarkBlue, ConsoleColor.DarkYellow);

            IPrintable triengleIprint = (IPrintable)triengle;

            triengleIprint.ShowInfo();

            Console.WriteLine(new string('*', 60));

            var cat = new Cat("Murzik", "Brazilskiy", 2f, 12.5f);

            IDrawable catIdawable = cat;
            if (catIdawable != null)
            {
                catIdawable.ShowInfo();
                catIdawable.Draw(ConsoleColor.Black, ConsoleColor.DarkYellow);
            }

          //  IPrintable catIprintable = cat as IPrintable;
            if (cat is IPrintable catIprintable)
            {
                catIprintable.ShowInfo();
                Cat? justCat = catIprintable as Cat;
                justCat?.Print();
            }
        }
    }
}
