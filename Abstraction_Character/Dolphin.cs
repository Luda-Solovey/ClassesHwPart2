namespace Abstraction_Character
{
    public class Dolphin : Character
    {
        public Dolphin(string name)
        : base(name)
        {
        }
        public override string Clean()
        {
            IsClean = true;
            return $"I`m dolphin. I can`t clean anything";
        }

        public override string SendToBed()
        {
            return $"Dolphin went to bad";
        }

        public override string Wash()
        {
            IsClean = true;
            return $"I`m dolphin. I wash my body all the time";
        }
    }
}
