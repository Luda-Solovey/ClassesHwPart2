namespace Structure_VolodimyrTask
{
    public class Program
    {
        /// <summary>
        /// Від мене - Створити структуру Point  - поля x, y, name, consoleColor
        /// методи Drow - виводить координати на екран відповідним кольором. 
        /// Add(Point other) - складає координати  і створює новий екземпляр Point
        ///створіть масив з поінтів присвойте 3 елемент з масива в змінну
        ///змініть координати - виведіть знову масив - перевірте результати
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Point[] pointArray =
            [
                new Point(1, 2, "A", ConsoleColor.Red),
                new Point(3, 4, "B", ConsoleColor.Green),
                new Point(5, 6, "C", ConsoleColor.Blue),
                new Point(7, 8, "D", ConsoleColor.Yellow),
            ];

            Point point = pointArray[2]; // присвоюємо 3 елемент масиву в змінну
            point.Draw(); // виводимо координати на екран

            point.Add(new Point(10, 10, "E", ConsoleColor.Cyan)); // змінюємо координати

            point.Draw(); // виводимо новий поінт на екран

        }
    }
}
