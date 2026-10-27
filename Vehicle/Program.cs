namespace VehicleApp
{
    /// <summary>
    /// Поліморфізм та наслідування
    /// Створити клас VehicleApp. У тілі класу створіть поля: координати та параметри суден (ціна, швидкість, рік випуску). 
    /// Створіть 3 похідні класи Plane, Саг і Ship. Для класу Plane має бути визначена висота та кількість пасажирів.
    /// Для класу Ship – кількість пасажирів та порт приписки. Написати програму, яка виводить на екран інформацію про кожен засіб пересування. 
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Vehicle ship = new Ship("Avrora", new Point(10, 20), 100000, 100, 2002, 180, "Santiago");
            Vehicle plane = new Plane("TU-214", new Point(35, 80), 500000,  300, 2025, 300, 2000);
            Vehicle car = new Car("Ferrary", new Point(80, 75), 150000, 180, 2024);

            Vehicle[] vehicles = [ship, plane, car];
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.GetInformation());
                
            }

        }
    }
}
