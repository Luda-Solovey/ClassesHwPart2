namespace StructEmployee
{
    public class Employee
    {
        public string Name { get; }

        public string SurName { get; set; }

        public DateOnly BirthdayDate { get; }

        public DateOnly DateOfHiring { get; }

        public double BaseSalary { get; set; }
        

        public Employee(string name, string surName, DateOnly birthdayDate, DateOnly dateOfHiring)
        {
            Name = name;
            SurName = surName;
            BirthdayDate = birthdayDate;
            DateOfHiring = dateOfHiring;
            BaseSalary = 10000;
        }


        public static void IncreaseSalary(Employee[] employee)
        {
            foreach (var emp in employee)
            {
                int expirience = emp.GetExpirienceInYears();
                int age = emp.GetAgeInYears();

                if (expirience > 5)
                {
                    emp.BaseSalary *= 1 + (expirience - 5) * 0.05;
                }

                if (age < 40)
                {
                    emp.BaseSalary *= 1.05;
                }
            }
        }

        public static void PrintEmployeeInfo(Employee[] employee)
        {
            for (int i = 0; i < employee.Length; i++)
            {
                Console.WriteLine($"Ім'я: {employee[i].Name}");
                Console.WriteLine($"Прізвище: {employee[i].SurName}");
                Console.WriteLine($"Дата народження: {employee[i].BirthdayDate}");
                Console.WriteLine($"Дата прийому на роботу: {employee[i].DateOfHiring}");
                Console.WriteLine($"Базова зарплата: {employee[i].BaseSalary}");
                Console.WriteLine($"Досвід роботи: {employee[i].GetExpirienceInYears()} років");
                Console.WriteLine();
            }
        }

        public int GetExpirienceInYears()
        {
           TimeSpan duration = DateTime.Today - DateOfHiring.ToDateTime(TimeOnly.MinValue);

            return (int)(duration.TotalDays / 365.25);
        }

        public int GetAgeInYears()
        {
            TimeSpan age = DateTime.Today - BirthdayDate.ToDateTime(TimeOnly.MinValue);
            return (int)(age.TotalDays / 365.25);
        }
    }
}
