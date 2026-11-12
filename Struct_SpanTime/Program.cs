namespace Struct_SpanTime
{
    internal class Program
    {
        /// <summary>
        /// Реалізуйте програму, яка прийматиме від користувача дату народження і виводити кількість днів до наступного дня народження  відносно поточної дати.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            //Console.WriteLine("Введіть вашу дату народження (у форматі РРРР-ММ-ДД):");
            //string? input = Console.ReadLine();

            //bool isValidDate = DateOnly.TryParse(input, out DateOnly nextBirthDate);

            //if (!isValidDate)
            //{
            //    Console.WriteLine("Невірний формат дати. Будь ласка, введіть дату у форматі РРРР-ММ-ДД.");
            //    return;
            //}

            //DateOnly today = DateOnly.FromDateTime(DateTime.Today);

            //DateOnly nextBirthday = new DateOnly(today.Year, nextBirthDate.Month, nextBirthDate.Day);
            //if (nextBirthday == today)
            //{
            //    Console.WriteLine("Вітаємо з днем народження!");
            //    return;
            //}
            //else if (nextBirthday < today)
            //{
            //    nextBirthday = nextBirthday.AddYears(1);
            //}

            //int daysUntilNextBirthday = nextBirthday.DayNumber - today.DayNumber;
            //Console.WriteLine($"До наступного дня народження залишилось {daysUntilNextBirthday} днів.");

            //-----------------------------------------------------------------------------
            //через DateTime
            Console.WriteLine("Введіть вашу дату народження у форматі РРРР-ММ-ДД:");
            string? input = Console.ReadLine();

            bool isValidDate = DateTime.TryParse(input, out DateTime birthDate);

            if (!isValidDate)
            {
                Console.WriteLine("Невірний формат дати. Будь ласка, введіть дату у форматі РРРР-ММ-ДД.");
                return;
            }
            DateTime today = DateTime.Today;
            DateTime nextBirthDate = new DateTime(today.Year, birthDate.Month, birthDate.Day);
            if (nextBirthDate < today)
            {
                nextBirthDate = nextBirthDate.AddYears(1);
            }

            TimeSpan daysLeft = nextBirthDate - today;

            if (daysLeft.Days == 0)
            {
                Console.WriteLine("Вітаємо з днем народження!");
            }
            else
            {
                Console.WriteLine($"(Через DateTime) До наступного дня народження залишилось {daysLeft} днів.");
            }

        }
    }
}
