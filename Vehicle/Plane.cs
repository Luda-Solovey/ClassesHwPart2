namespace VehicleApp
{
    internal class Plane : Vehicle
    {
        public Plane(string name, Point points, int price, int speed, int manufactureYear, int passengersCount, int flightAltitude)
        : base (name, points, price, speed, manufactureYear)
        {
            PassagersCount = passengersCount;
            FlightAltitude = flightAltitude;
        }

        public int FlightAltitude { get; set; }

        public int PassagersCount { get; }

        public override string GetInformation()
        {
            return $"I`m PLANE {Name}, coordinate X - {Points?.X}, coordinate Y - {Points?.Y}, price - {Price}, speed - {Speed}, yearOfManufacture - {YearOfManufacture}, passager count - {PassagersCount}, flight altitude = {FlightAltitude}";
        }
    }
}
