namespace Figure_Interfaces
{
    public class Program
    {
        /// <summary>
        /// Завдання: інтерфейси та абстрактні класи в C#
        //        Частина 1. Фігури
        //        Створіть абстрактний клас Figure: властивість Name(назва фігури);
        //        дві абстрактні властивості для сторін(наприклад, SideA і SideB);
        //        методи обчислення периметра та площі GetPerimeter() і GetArea().
        //Продумайте: ці методи мають бути abstract чи virtual? Обґрунтуйте вибір.
        //Створіть клас Rectangle, успадкований від Figure, і реалізуйте в ньому всі абстрактні члени.
        //Створіть інтерфейс IDrawable:
        //властивість Name;
        //        метод void Draw(ConsoleColor backColor, ConsoleColor foreColor): виводить назву фігури та її малюнок зірочками(за допомогою циклів) заданими кольорами.Малюнок може бути простим, головне щоб це були зірочки;
        //        метод void ShowInfo().
        //Створіть інтерфейс IPrintable:
        //метод void Print(): малює фігуру зірочками стандартним кольором консолі;
        //        метод void ShowInfo().
        //Клас Rectangle реалізує IDrawable та IPrintable.Метод ShowInfo() виводить в один рядок: назву фігури, сторони, площу та периметр.
        //Частина 2. Тварини
        //Створіть абстрактний клас Animal (наприклад, з властивостями Name, Breed, Size, Weight).
        //Створіть клас Cat, який успадковується від Animal і реалізує обидва інтерфейси: IDrawable та IPrintable.
        //Метод ShowInfo() для кота має працювати по - різному:
        //у контексті IDrawable виводить породу, розмір і вагу;
        //у контексті IPrintable виводить лише назву(кличку) і породу.
        //Питання для обговорення
        //В обох інтерфейсах є метод ShowInfo() з однаковою сигнатурою, тобто виникає конфлікт імен. Що ви оберете:
        //одну спільну реалізацію на обидва інтерфейси, чи
        //явну (explicit) реалізацію окремо для кожного інтерфейсу
        /// </summary>
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
