namespace VehicleApp
{
    public class Car : Vehicle
    {
        public Car(string name, int x, int y, int price, int speed, int manufactureYear)
        : base(name, x, y, price, speed, manufactureYear)
        {
            
        }

        public override void GetInformation()
        {
            Console.WriteLine($"I`m CAR {Name}, coordinate X - {X}, coordinate Y - {Y}, price - {Price}, speed - {Speed}, yearOfManufacture - {YearOfManufacture}");
        }
    }
}
