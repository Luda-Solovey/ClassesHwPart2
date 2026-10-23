namespace PrinterApp
{
    /// <summary>
    /// Поліморфізм та наслідування
    /// Створити клас Printer. У тілі класу створіть метод void Print(string value), що виводить на екран значення аргументу. 
    /// Реалізуйте можливість того, щоб у разі успадкування від даного класу інших класів, та виклику відповідного методу їх екземпляра, рядки,
    /// передані як аргументи методів, виводилися різними кольорами. Обов'язково використовуйте типи.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new();

            ColorPrinter colorPrinter = new();

            Printer[] setOfPrinters = [printer, colorPrinter];
            foreach (var item in setOfPrinters)
            {
                item.Print("This is text for printing");
            }
        }
    }
}
