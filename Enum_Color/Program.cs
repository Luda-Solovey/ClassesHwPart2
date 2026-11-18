namespace Enum_Color
{
    internal class Program
    {
        /// <summary>
        /// Створіть статичний клас із методом void Print (string stroka, int color), який виводить на екран рядок заданим кольором. 
        /// Використовуючи перелік, створіть набір кольорів, доступних користувачеві. Введення рядка та вибір кольору надайте користувачеві. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string stroka = "Це завдання по енамам!";
            Console.WriteLine("Виберіть колір тексту:");
            ColorAssistant.Print(stroka, ColorSet.Green);
        }
    }
}
