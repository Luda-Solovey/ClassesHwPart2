using System.Text;

namespace StructNotebook
{
    public class Program
    {
        /// <summary>
        /// Створіть структуру з ім'ям – Notebook. Поля структури: модель, виробник, вартість. 
        /// У структурі має бути реалізований конструктор для ініціалізації полів та метод для виведення вмісту полів на екран.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Notebook[] notebooks = [
                new ("Slim 15A", "Lenovo", 20000m),
                new ("MacBook Pro", "Apple", 50000m),
                new ("ThinkPad X1", "Lenovo", 30000m),
                new ("Surface Laptop", "Microsoft", 40000m),
                new ("Inspiron 15", "Dell", 25000m)
                ];

            foreach (var notebook in notebooks)
            {
                notebook.DisplayInfo();
            }
        }
    }
}
