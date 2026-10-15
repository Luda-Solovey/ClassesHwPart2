namespace User
{
    public class User(string login, string firstName, string lastName, DateOnly age)
    {
        public string Login { get; private set; } = login;

        public string FirstName { get; private set; } = firstName;

        public string LastName { get; private set; } = lastName;

        public DateOnly Age { get; private set; } = age;

        public DateOnly DateOfQuestionnaireFilling { get; init; } 

        public void DisplayUserInfo()
        {
            Console.WriteLine($"Login: {Login}");
            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Fill Questionnaire: {DateOfQuestionnaireFilling}");
        }
    }
}
