namespace Abstraction_Character
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character dolphin = new Dolphin();
            Character parrot = new Parrot();
            Character cat = new Cat();
            Character dog = new Dog();

            Character[] characters = [dolphin, cat, dog, parrot];

            foreach (var character in characters)
            {
                Console.WriteLine(character.Clean());
                Console.WriteLine(character.Feed());
                Console.WriteLine(character.Play());
                Console.WriteLine(character.SendToBed());
                Console.WriteLine(character.GiveInformationAboutCurrentState());
                Console.WriteLine(new string('*', 30));
            }
        }
    }
}
