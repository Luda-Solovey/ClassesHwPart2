namespace Enum_Color
{
    public static class ColorAssistant
    {
        public static void Print(string stroka, ColorSet color)
        {
            string colorName = color.ToString();

            //параметр true дозволяє не враховувати регістр при порівнянні рядків
            //IsDefined перевіряє, чи є значення в enum-і
            if (Enum.TryParse(colorName, true, out ConsoleColor parsedColor) && Enum.IsDefined(parsedColor)) // замість Enum.IsDefined(typeof(ConsoleColor), parsedColor)), в якому буде боксінг\анбоксінг краще використовувати версію метода дженерік - IsDefined<TEnum>(TEnum))
            {
                Console.ForegroundColor = parsedColor;
                Console.WriteLine(stroka);
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("введений колір не представлений в переліку ConsoleColor. Оберіть інший колір.");
                return;
            }
        }
    }
}
