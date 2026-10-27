namespace VehicleApp
{
    public class Car : Vehicle
    {
        public Car(string name, Point points, int price, int speed, int manufactureYear)
        : base(name, points, price, speed, manufactureYear)
        {
            
        }

        public override string GetInformation()
        {
           return $"I`m CAR {Name}, coordinate X - {Points?.X}, coordinate Y - {Points?.Y}, price - {Price}, speed - {Speed}, yearOfManufacture - {YearOfManufacture}";
        }
    }
}
