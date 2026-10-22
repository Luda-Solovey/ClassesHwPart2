namespace VehicleApp
{
    public class Ship : Vehicle
    {
        public Ship(string name, int x, int y, int price, int speed, int manufactureYear, int passengersCount, string port) : base(name, x, y, price, speed, manufactureYear)
        {
            PassengerCount = passengersCount;
            Port = port;
        }
        public string Port { get; }
        public int PassengerCount { get; }

        public override void GetInformation()
        {
            Console.WriteLine($"I`m SHIP {Name}, coordinate X - {X}, coordinate Y - {Y}, price - {Price}, speed - {Speed}, yearOfManufacture - {YearOfManufacture}, passenger count - {PassengerCount}, port - {Port}");
        }
    }
}
