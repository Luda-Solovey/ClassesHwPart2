namespace VehicleApp
{
    public class Ship : Vehicle
    {
        public Ship(string name, Point points, int price, int speed, int manufactureYear, int passengersCount, string port) : base(name, points, price, speed, manufactureYear)
        {
            PassengerCount = passengersCount;
            Port = port;
        }
        public string Port { get; }
        public int PassengerCount { get; }

        public override string GetInformation()
        {
            return $"I`m SHIP {Name}, coordinate X - {Points?.X}, coordinate Y - {Points?.Y}, price - {Price}, speed - {Speed}, yearOfManufacture - {YearOfManufacture}, passenger count - {PassengerCount}, port - {Port}";
        }
    }
}
