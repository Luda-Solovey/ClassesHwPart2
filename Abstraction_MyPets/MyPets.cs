namespace Abstraction_MyPets
{
    internal class MyPets
    {
        public Pet MyPet { get; set; }

        public int HungryLevel { get; set; }

        public List<Pet> PetList { get; set; }

        public MyPets(Pet pet)
        {
            MyPet = pet;
        }

        public string CreatePet(Pet pet)
        {
            PetList.Add(pet);
            return $"Pet {pet} is added to the list of pets.";
        }
    }
}
