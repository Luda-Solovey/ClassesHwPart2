namespace EmployeeSalary
{
    internal class Program
    {
        /// <summary>
        ///Завдання 3
        /// Використовуючи Visual Studio, створіть проект за шаблоном Console Application. Потрібно створити клас Employee. 
        /// У тілі класу створити користувальницький конструктор, який приймає два рядкові аргументи, та ініціалізує поля, 
        /// що відповідають прізвищу та імені співробітника. Створити метод, що розраховує оклад співробітника (залежно від посади та стажу) 
        /// та податковий збір. Написати програму, яка виводить на екран інформацію про співробітника (прізвище, ім'я, посада), оклад та податковий збір.
        /// </summary>
        /// 
        static void Main(string[] args)
        {
            Employee employee = new Employee("Illia", "Shevchenko", Position.Engineer, new DateOnly(2016, 6, 1));
            Console.WriteLine($"Employee: {employee.FirstName} {employee.LastName}");

            decimal salary = employee.CalculateSalary(employee.Position);
            Console.WriteLine($"Salary: {salary}");

            decimal tax = employee.CalculateTax();
            Console.WriteLine($"Tax: {tax}");
        }
    }
}
