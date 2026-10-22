namespace VehicleApp
{
    internal class Plane : Vehicle
    {
        public Plane(string name, int x, int y, int price, int speed, int manufactureYear, int passengersCount, int flightAltitude)
        : base (name, x, y, price, speed, manufactureYear)
        {
            PassagersCount = passengersCount;
            FlightAltitude = flightAltitude;
        }

        public int FlightAltitude { get; set; }

        public int PassagersCount { get; }

        public override void GetInformation()
        {
            Console.WriteLine($"I`m PLANE {Name}, coordinate X - {X}, coordinate Y - {Y}, price - {Price}, speed - {Speed}, yearOfManufacture - {YearOfManufacture}, passager count - {PassagersCount}, flight altitude = {FlightAltitude}");
        }
    }
}
