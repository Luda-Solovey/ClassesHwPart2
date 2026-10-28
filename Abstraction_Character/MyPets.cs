namespace Abstraction_Character
{
    internal class MyPets
    {
        //public Character MyPet { get; set; }

        public static List<Character> PetList { get; set; } = new();

        public string CreatePet(Character pet)
        {
            PetList.Add(pet);
            return $"Pet {pet} is added to the list of pets.";
        }

        public void WakeUpPet(List<Character> petList)
        {
            foreach (var pet in petList)
            {
                if (pet.IsAwake ==false)
                {
                    pet.IsAwake = true;
                }
            }
        }

        public void PutToBad(List<Character> petsList)
        {
            foreach (var pet in petsList)
            {
                if (pet.IsAwake == true)
                {
                    pet.IsAwake = false;
                }
            }
        }
    }
}
