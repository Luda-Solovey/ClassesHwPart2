namespace Abstraction_Character
{
    internal class Parrot : Character
    {
        public override List<FoodTypes> AvailiableFood => new() { FoodTypes.Grain };

        public Parrot(string name)
        : base(name)
        {
        }
        public override void Clean()
        {
            Console.WriteLine($"I`m parrot.They cleaned up after me.");
        }

        public override void Wash()
        {
            base.Wash();
            Console.WriteLine($"I`m parrot. I wash my face in the mornings and in the evenings");
        }

        public override void SendToBed()
        {
            base.SendToBed();
            Console.WriteLine($"parrot went to sleep.");
        }

        public override void Speek()
        {
            Console.WriteLine($"Parrot says \"Chik-chirik\"");
        }

        public override void DoActivity()
        {
            Console.WriteLine("Parrot sings songs and looks at the mirror.");
        }
    }
}
