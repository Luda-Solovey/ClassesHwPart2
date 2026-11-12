namespace StructTrain
{
    public struct Train
    {
        public Train(string destination, int number, DateTime departureTime)
        {
            Destination = destination;
            Number = number;
            DepartureTime = departureTime;
        }
        public string Destination { get; }

        public int Number { get; }

        public DateTime DepartureTime { get; }

        public override string ToString()
        {
            return $"Destination: {Destination}, Number: {Number}, Departure Time: {DepartureTime}";
        }
    }
}
