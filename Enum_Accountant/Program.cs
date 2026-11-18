using System.Text;

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
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("Employees has bonus or not");
            Employee developer = new ("John", "Doe", Position.Developer);
            bool isBonusDueDeveloper = Accountant.AskForBonus(developer, 200);
            Console.WriteLine($"{developer.FullName} - {isBonusDueDeveloper}");

            Employee designer = new Employee("Alex", "Bespalov", Position.Designer);
            bool isBonusDueDesigner = Accountant.AskForBonus(designer, 170);
            Console.WriteLine($"{designer.FullName} - {isBonusDueDesigner}");

            Employee tester = new Employee("Illia", "Sokol", Position.Tester);
            bool isBonusDueTester = Accountant.AskForBonus(tester, 200);
            Console.WriteLine($"{tester.FullName} - {isBonusDueTester}");

            //Employee[] employeeList = [developer, designer, tester];
            //Console.WriteLine("Bonus will get:");
            //for (int i = 0; i < employeeList.Length; i++)
            //{
            //    if (employeeList[i].)
            //    {

            //    }
            //}
        }
    }
}
