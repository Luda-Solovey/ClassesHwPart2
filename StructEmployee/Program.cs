namespace StructEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            // Створення екземпляру структури Employee
            Employee employee = new ("Іван", "Петренко", new DateOnly(1950, 1, 1), new DateOnly(2018, 12, 19));
            Employee employee2 = new ("Петро", "Іваненко", new DateOnly(2000, 5, 15), new DateOnly(2018, 6, 10));
            Employee[] employees = { employee, employee2 };

            //// Виклик методу для виведення інформації про працівника
            //Employee.PrintEmployeeInfo(employees);
            //Employee.IncreaseSalary(employees);
            //Employee.PrintEmployeeInfo(employees);

            TimeSpan ts1 = TimeSpan.FromDays(5);
            TimeSpan ts2 = TimeSpan.FromHours(2.5);
            TimeSpan ts3 = TimeSpan.FromMinutes(90);

            TimeSpan ts = new TimeSpan(1, 12, 05, 30);// 25 днів, 12 годин, 5 хвилин, 30 секунд
            Console.WriteLine(ts);

            TimeSpan ts4 = TimeSpan.FromDays(7); // 7 днів
            TimeSpan ts5 = TimeSpan.FromHours(1.5); // 1 година, 30 хвилин
            TimeSpan ts6 = TimeSpan.FromMinutes(90); // 1 година, 30 хвилин

            Console.WriteLine(ts4);
            Console.WriteLine(ts5);
            Console.WriteLine(ts6);

            DateTime dt1 = new DateTime(2025, 11, 06);
            DateTime dt2 = new DateTime(2026, 11, 12);

            TimeSpan durr = dt2 - dt1;
            Console.WriteLine(durr.Days);
            Console.WriteLine(durr.Hours);
            Console.WriteLine(durr.Minutes);


        }
    }
}
