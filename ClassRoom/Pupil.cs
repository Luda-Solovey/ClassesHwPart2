namespace ClassRoom
{
    public class Pupil
    {
        public string FirstName { get; }

        public string LastName { get; }

        public string MiddleName { get; }

        public string FullName
        {
            get => FirstName + ' ' + LastName;
        }

        public DateOnly DateOfBirthday { get; }

        public Passport? Passport { get; } = new Passport("AA", 123456, new DateOnly(1999, 12, 12));

        public Pupil(string firstName, string lastName, string middleName, DateOnly dateOfBirthday)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            DateOfBirthday = dateOfBirthday;
        }

        public Pupil(string firstName, string lastName, string middleName, DateOnly dateOfBirthday, string seriaPasport, int numberPassport, DateOnly dataPassportIssue)
            :this(firstName, lastName, middleName, dateOfBirthday)
        {
            Passport = new Passport(seriaPasport, numberPassport, dataPassportIssue);// питання: чи правильно, що паспорт реалізувала через композицію (чи таки потрібна агрегація)
        }

        public virtual void Study()
        {
            Console.WriteLine("I`m a student. I study");
        }

        public virtual void Read()
        {
            Console.WriteLine("I`m a student. I read");
        }

        public virtual void Write()
        {
            Console.WriteLine("I`m a student. I write");
        }

        public virtual void Relax()
        {
            Console.WriteLine("I`m a student. I relax");
        }

        public virtual void GetFullInformation()
        {
            Study();
            Read();
            Write();
            Relax();
        }
    }
}
