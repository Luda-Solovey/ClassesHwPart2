namespace Abstraction_Character
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character dolphin = new Dolphin("Dol");
            Character parrot = new Parrot("Kesha");
            Character cat = new Cat("Barsik");
            Character dog = new Dog("Djina");

            Character[] characters = [dolphin, cat, dog, parrot];

            foreach (var character in characters)
            {
                character.Feed();
                character.Play();
                character.PassHour();
                Console.WriteLine(character.Clean());
                Console.WriteLine(character.SendToBed());
                Console.WriteLine(character.GiveInformationAboutCurrentState());
                Console.WriteLine(new string('*', 30));
                character.SendToBed();
                Console.WriteLine();
            }

            Console.WriteLine(new string('*', 50));

            var petList = characters.ToList<Character>();

            MyPets myPets = new();

            myPets.WakeUpPet(petList);

            foreach (var pet in petList)
            {
                Console.WriteLine($"Pet {pet.Name} IsAwake is {pet.IsAwake}");
            }

            myPets.PutToBad(petList);
            foreach (var pet in petList)
            {
                Console.WriteLine($"Pet {pet.Name} IsAwake is {pet.IsAwake}");
            }

        }
    }
}
