namespace Abstraction_Character
{
    internal class Dog : Character
    {
        public Dog(string name)
        : base(name)
        {
        }
        public override string Clean()
        {
            IsClean = true;
            return $"I`m dog. I can`t clean anything";
        }

        public override string Wash()
        {
            IsClean = true;
            return $"I`m dog. I don`t wash my body";
        }

        public override string SendToBed()
        {
            IsAwake = false;
            return $"Dog went to sleep.";
        }
    }
}
