namespace Abstraction_Character
{
    public class Cat : Character
    {
        public override List<FoodTypes> AvailiableFood => new() { FoodTypes.Beef, FoodTypes.CatFood, FoodTypes.Fish };

        public Cat(string name)
        : base(name)
        {
        }

        public override void Clean()
        {
            Console.WriteLine($"I`m cat.They cleaned up after me.");
        }

        public override void Wash()
        {
            base.Wash();
            Console.WriteLine($"I`m cat. I wash my face in the mornings and in the evenings");
        }

        public override void SendToBed()
        {
            base.SendToBed();
            Console.WriteLine( $"Cat went to sleep.");
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
