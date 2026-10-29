namespace Abstraction_Character
{
    public class Dolphin : Character
    {
        public Dolphin(string name)
        : base(name)
        {
        }

        public override List<FoodTypes> AvailiableFood => new() { FoodTypes.Algae, FoodTypes.Fish };

        public override void Clean()
        {
            Console.WriteLine( $"I`m dolphin. I can`t clean anything");
        }

        public override void DoActivity()
        {
            throw new NotImplementedException();
        }

        public override void SendToBed()
        {
            base.SendToBed();
            Console.WriteLine( $"Dolphin sleep in the see");
        }

        public override void Speek()
        {
            throw new NotImplementedException();
        }

        public override void Wash()
        {
            IsClean = true;
            Console.WriteLine( $"I`m dolphin. I wash my body all the time");
        }
    }
}
