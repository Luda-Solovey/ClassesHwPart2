
namespace Enum_Employee
{
    public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName => FirstName + " " + LastName;

        public Employee(string firstName, string lastName, Position position)
        {
            FirstName = firstName;
            LastName = lastName;
            Position = position;
        }

        public Position Position { get; set; }


    }
}
