namespace VehicleApp
{
    /// <summary>
    /// Створити клас VehicleApp. У тілі класу створіть поля: координати та параметри суден (ціна, швидкість, рік випуску).
    /// Створіть 3 похідні класи Plane, Саг і Ship. Для класу Plane має бути визначена висота та кількість пасажирів. 
    /// Для класу Ship – кількість пасажирів та порт приписки. Написати програму, яка виводить на екран інформацію про кожен засіб пересування. 
    /// </summary>
    public class Vehicle
    {
        public string Name { get; }

        public int X { get; set; }

        public int Y { get; set; }

        public int Price { get; }
        public int Speed { get; }

        public int YearOfManufacture { get; }

        public Vehicle(string name, int x, int y, int price, int speed, int manufactureYear)
        {
            Name = name;
            X = x;
            Y = y;
            Price = price;
            Speed = speed;
            YearOfManufacture = manufactureYear;

        }

        public virtual void GetInformation()
        {
            Console.WriteLine($"VehicleApp - {Name}, coordinate X - {X}, coordinate Y - {Y}, price - {Price}, speed - {Speed}, yearOfManufacture - {YearOfManufacture}");
        }
    }
}
