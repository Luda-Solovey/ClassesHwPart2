namespace Figure_Interfaces
{
    public class Animal(string name, string breed, float size, float weight)
    {
        //Name, Breed, Size, Weight
        public string Name { get; set; } = name;
        public string Breed { get; set; } = breed;
        public float Size { get; set; } = size;
        public float Weight { get; set; } = weight;
    }
}
