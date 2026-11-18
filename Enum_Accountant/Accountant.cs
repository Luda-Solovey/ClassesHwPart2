
namespace Enum_Employee
{
    public class Accountant
    {

        /// <summary>
        /// Створіть перелік, який містить посади співробітників як імена констант.
        /// Надайте кожній константі значення, що задає кількість годин, які повинен відпрацювати співробітник протягом місяця.
        /// Створіть клас Accountant з методом bool AskForBonus (Post worker, int workedHours), що відображатиме давати співробітнику премію.
        /// Якщо співробітник відпрацював більше годин на місяць, то йому належить премія
        /// </summary>
        /// <param name="args"></param>
        public static bool AskForBonus(Employee worker, int workedHours)
        {
            int requiredHours = (int)worker.Position;
            return workedHours > requiredHours;
        }

        //public static void AskForBonus(Employee[] workers, int workedHours)
        //{
        //    foreach (var worker in workers)
        //    {
        //        Console.WriteLine($"Employee {worker.FirstName} {worker.LastName} deserves bonus: {(int)worker.Position > workedHours}");
        //    }
        //}
    }
}

