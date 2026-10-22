namespace EmployeeSalary
{
    public class Employee
    {
        public string FirstName { get; set; }
        public  string LastName { get;  set; }
        public Position Position { get; set; }
        private const decimal BaseSalary = 1000m; 
        private const decimal PDFRate = 0.18m; // 18% ПДФ
        private const decimal MilitaryRate = 0.015m; // 1.5% військовий збір
        public DateOnly DateOfHire { get; }
        public int Expirience => GetExperience();
        
        public Employee(string firstName, string lastName, Position position, DateOnly dateOfHire)
        {
            FirstName = firstName;
            LastName = lastName;
            Position = position;
            DateOfHire = dateOfHire;
        }

        private decimal CalculateSalary(Position position)
        {
            decimal salary = BaseSalary;
            switch (position)
            {
                case Position.Director:
                    salary = BaseSalary * 2m;
                    break;
                case Position.Engineer:
                    salary = BaseSalary * 1.5m;
                    break;
                case Position.Manager:
                    salary = BaseSalary * 1.2m;
                    break;
                case Position.Cleaner:
                    salary = BaseSalary * 0.9m;
                    break;
                default:
                    break;
            }

            double experienceBonus = Expirience switch
            {
                <3 => 1,
                >=3 and < 5 => 1.1,
                >= 5 and < 10 => 1.2,
                >=10 and < 15 => 1.3,
                >=15 => 1.4
            };

            return salary *= (decimal)experienceBonus;
        }

        private decimal CalculateTax()
        {
            var salary = CalculateSalary(Position);
            var tax = salary * (PDFRate + MilitaryRate); // ?
            return tax;
        }

        private int GetExperience()
        {
            DateOnly todayDate = DateOnly.FromDateTime(DateTime.Now);
            int year = todayDate.Year - DateOfHire.Year;
            if (todayDate < DateOfHire.AddYears(year))
            {
                year--;
            }
            return year;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Employee: {FirstName} {LastName}");
            Console.WriteLine($"Position: {Position}");
            Console.WriteLine($"Experience: {Expirience} years");
            Console.WriteLine($"Salary: {CalculateSalary(Position)}");
            Console.WriteLine($"Tax: {CalculateTax()}");
        }
    }
}
