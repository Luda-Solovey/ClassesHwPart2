using System.Text;

namespace ClassesHwPart2
{
    public class Program
    {
        //Завдання 2 
        //Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
        //Потрібно: Створити клас Converter.У тілі класу створити користувальницький конструктор,
        //який приймає три речові аргументи, і ініціалізує поля, що відповідають курсу 3-х основних валют,
        //по відношенню до гривні – public Converter(double usd, double eur, double gbt). Написати програму,
        //яка виконуватиме конвертацію з гривні в одну із зазначених валют, також програма повинна проводити конвертацію із зазначених валют у гривню.

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            //ввод курсів валют та суми конвертації 
            Console.WriteLine("Введіть поточні курси:");
            Console.WriteLine("Введіть курс USD до UAN:");
            string? input = Console.ReadLine();
            if (!double.TryParse(input?.Replace('.', ','), out double usdToUan))
            {
                Console.WriteLine("Невірний формат курсу USD.");
                return;
            }

            Console.WriteLine("Введіть курс EUR до UAN:");
            string? eurInput = Console.ReadLine();
            if (!double.TryParse(eurInput?.Replace('.', ','), out double eurToUan))
            {
                Console.WriteLine("Невірний формат курсу EUR.");
                return;
            }

            Console.WriteLine("Введіть курс GBT до UAN:");
            string? gbtInput = Console.ReadLine();
            if (!double.TryParse(gbtInput?.Replace('.', ','), out double gbtToUan))
            {
                Console.WriteLine("Невірний формат курсу GBT.");
                return;
            }

            //ввод валюти для конвертації та суми
            Console.WriteLine("Введіть валюту, яку бажаєте конвертувати: UAN, USD, EUR, GBT");
            string? convertFrom = Console.ReadLine()?.ToUpper();
            if (convertFrom == null)
            {
                Console.WriteLine("Невірний формат валюти.");
                return;
            }

            Console.WriteLine("Введіть валюту, в яку бажаєте конвертувати: UAN, USD, EUR, GBT");
            string? converTo = Console.ReadLine()?.ToUpper();
            if (converTo == null)
            {
                Console.WriteLine("Невірний формат валюти.");
                return;
            }

            Console.WriteLine("Введіть суму конвертації:");
            string? amountInput = Console.ReadLine();
            amountInput = amountInput?.Replace(".", ","); // Замінюємо крапку на кому для правильного парсингу

            if (!double.TryParse(amountInput, out double amount))
            {
                Console.WriteLine("Невірний формат суми.");
                return;
            }

            //логіка для конвертації
            Converter converter = new Converter(usdToUan, eurToUan, gbtToUan);

            if (convertFrom == Currencies.UAN.ToString())
            {
                switch (converTo)
                {
                    case "USD":
                        var result = converter.ConvertGrnToUsd(amount);
                        Console.WriteLine($"Результат конвертації: {result}");
                        break;
                    case "EUR":
                        result = converter.ConvertGrnToEur(amount);
                        Console.WriteLine($"Результат конвертації: {result}");
                        break;
                    case "GBT":
                        result = converter.ConvertGrnToGbt(amount);
                        Console.WriteLine($"Результат конвертації: {result}");
                        break;
                    default:
                        Console.WriteLine("Невірна валюта для конвертації.");
                        break;
                }
            }

            else
            {
                switch (convertFrom)
                {
                    case "USD":
                        var result = converter.ConvertUsdToGrn(amount);
                        Console.WriteLine($"Результат конвертації: {result}");
                        break;
                    case "EUR":
                        result = converter.ConvertEurToGrn(amount);
                        Console.WriteLine($"Результат конвертації: {result}");
                        break;
                    case "GBT":
                        result = converter.ConvertGbtToGrn(amount);
                        Console.WriteLine($"Результат конвертації: {result}");
                        break;
                    default:
                        Console.WriteLine("Невірна валюта для конвертації.");
                        break;
                }
            }

        }
    }
}
