namespace User
{
    public class Program
    {
        /// <summary>
        /// Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
        /// Потрібно: Створити клас User, що містить інформацію про користувача (логін, ім'я, прізвище, вік, дату заповнення анкети).
        /// Поле дата заповнення анкети має бути проініціалізоване лише один раз (при створенні екземпляра цього класу) без можливості його подальшої зміни. 
        /// Реалізуйте виведення на екран інформації про користувача.
        /// </summary>
        /// 
        static void Main(string[] args)
        {
            User user1 = new User("lsolovey", "Luda", "Solovey", new DateOnly(1987, 1, 1))
            {
                DateOfQuestionnaireFilling = new DateOnly(2026, 10, 1)
            };
            user1.DisplayUserInfo();
        }
    }
}
