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
            Console.WriteLine( $"I`m dolphin. I don`t need anyone clean up after me.");
        }

        public override void DoActivity()
        {
            Console.WriteLine("Dolphin surface and submerge in the water");
        }

        public override void SendToBed()
        {
            base.SendToBed();
            Console.WriteLine( $"Dolphin sleep in the see");
        }

        public override void Speek()
        {
            Console.WriteLine($"Dolphin makes whistling and chirping sounds");
        }

        public override void Wash()
        {
            IsClean = true;
            Console.WriteLine( $"I`m dolphin. I wash my body all the time");
        }
    }
}
