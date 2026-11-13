namespace EnumVolodymyrTask
{
    public class Department(string name, string address)
    {
        public string Name { get; set; } = name;

        public Employee? Chief { get; set; }

        public string Address { get; set; } = address;
    }
}
