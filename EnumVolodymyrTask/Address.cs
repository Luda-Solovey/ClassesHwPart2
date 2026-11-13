namespace EnumVolodymyrTask
{
    public class Address(string city, string street, int house)
    {
        public string City { get; set; } = city;

        public string Street { get; set; } = street;

        public int House { get; set; } = house;

        public int? Department { get; set; }

        public string? Comment { get; set; }

    }
}
