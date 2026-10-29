namespace Abstraction_Character
{
    internal class Dog : Character
    {
        public override List<FoodTypes> AvailiableFood => [FoodTypes.Bone, FoodTypes.DogFood, FoodTypes.Beef];

        public Dog(string name)
        : base(name)
        {
        }
        public override void Clean()
        {
            Console.WriteLine($"I`m dog.They cleaned up after me.");
        }

        public override void Wash()
        {
            base.Wash();
            Console.WriteLine($"I`m dog. I wash my face in the mornings and in the evenings");
        }

        public override void SendToBed()
        {
            base.SendToBed();
            Console.WriteLine($"Dog went to sleep.");
        }

        public override void Speek()
        {
            throw new NotImplementedException();
        }

        public override void DoActivity()
        {
            throw new NotImplementedException();
        }

    }
}
