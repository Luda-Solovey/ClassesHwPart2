using System.Text;

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
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("Введіть текст");
            string? enteredText = Console.ReadLine();

            Console.WriteLine("Введіть колір з доступних: ");
            foreach (ColorSet color in Enum.GetValues<ColorSet>())
            {
                Console.WriteLine($" - {color}");
            }
            string enteredColor = Console.ReadLine();

            if (enteredText is not null && enteredText is not null)
            {
                if (Enum.TryParse<ColorSet>(enteredColor, true, out ColorSet color) && Enum.IsDefined(color))
                {
                    ColorAssistant.Print(enteredText, color);
                }
                else
                {
                    Console.WriteLine("Введений невірний колір. Введіть інший колір.");
                }
            }

            //string stroka = "Це завдання по енамам!";
            //ColorAssistant.Print(stroka, ColorSet.Green);
        }
    }
}
