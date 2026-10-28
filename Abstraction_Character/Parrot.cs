namespace Abstraction_Character
{
    internal class Parrot : Character
    {
        public Parrot(string name)
        : base(name)
        {
        }
        public override string Clean()
        {
            IsClean = true;
            return $"I`m parrot. I clean my feathers";
        }

        public override string SendToBed()
        {
            IsAwake = false;
            return $"Parrot went to bad";
        }

        public override string Wash()
        {
            IsClean = true;
            return $"I`m parrot. Sometimes I wash my body";
        }
    }
}
