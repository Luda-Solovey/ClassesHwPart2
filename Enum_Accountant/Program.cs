namespace Enum_Employee
{
    public class Program
    {
        /// <summary>
        /// Створіть перелік, який містить посади співробітників як імена констант.
        /// Надайте кожній константі значення, що задає кількість годин, які повинен відпрацювати співробітник протягом місяця.
        /// Створіть клас Accountant з методом bool AskForBonus (Post worker, int hours), що відображатиме давати співробітнику премію.
        /// Якщо співробітник відпрацював більше годин на місяць, то йому належить премія
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Employee developer = new ("John", "Doe", Position.Developer);
            bool isBonusDueDeveloper = Accountant.AskForBonus(developer, 200);
            Console.WriteLine(isBonusDueDeveloper);

            Employee designer = new Employee("Alex", "Bespalov", Position.Designer);
            bool isBonusDueDesigner = Accountant.AskForBonus(designer, 170);
            Console.WriteLine(isBonusDueDesigner);

        }
    }
}
