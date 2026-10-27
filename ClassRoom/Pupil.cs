namespace ClassRoom
{
    public class Pupil
    {
        public string FirstName { get; }

        public string LastName { get; }

        public string MiddleName { get; }

        public string FullName => FirstName + ' ' + LastName;
        

        public DateOnly DateOfBirthday { get; }

        public Passport? Passport { get; }

        public Pupil(string firstName, string lastName, string middleName)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
        }

        public Pupil(string firstName, string lastName, string middleName, DateOnly dateOfBirthday, Passport passport)
        : this(firstName,  lastName,  middleName)
        {
            DateOfBirthday = dateOfBirthday;
            Passport?.Seria = passport.Seria;
            Passport?.Number = passport.Number;
            Passport?.DateOfIssue = passport.DateOfIssue;
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
    }
}
