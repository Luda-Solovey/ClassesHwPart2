namespace EnumVolodymyrTask
{
    public abstract class Person(string firstName, string lastName, string patronymic, Gender gender)
    {
        public string FirstName { get; set; } = firstName;

        public string LastName { get; set; } = lastName;

        public string Patronymic { get; set; } = patronymic;

        public Address? Address { get; set; }

        public Gender Gender { get; } = gender;
    }
}
