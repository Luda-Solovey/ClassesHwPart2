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

        public Point? Points { get; set; }

        public int Price { get; }
        public int Speed { get; }

        public int YearOfManufacture { get; }

        public Vehicle(string name, Point points, int price, int speed, int manufactureYear)
        {
            Name = name;
            Points?.X = points.X;
            Points?.Y = points.Y;
            Price = price;
            Speed = speed;
            YearOfManufacture = manufactureYear;

        }

        public virtual string GetInformation()
        {
            return $"VehicleApp - {Name}, coordinate X - {Points?.X}, coordinate Y - {Points?.Y}, price - {Price}, speed - {Speed}, yearOfManufacture - {YearOfManufacture}";
        }
    }
}
