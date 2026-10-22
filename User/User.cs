namespace User
{
    public class User(string login, string firstName, string lastName, DateOnly age)
    {
        public string Login { get; set; } = login;

        public string FirstName { get; set; } = firstName;

        public string LastName { get; set; } = lastName;

        public DateOnly Age { get; } = age;

        public required DateOnly DateOfQuestionnaireFilling { get; init; } 

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
