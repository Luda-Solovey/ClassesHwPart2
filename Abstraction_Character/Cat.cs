namespace Abstraction_Character
{
    public class Cat : Character
    {
        public Cat(string name)
        : base(name)
        {
        }

        public override string Clean()
        {
            IsClean = true;
            return $"I`m cat. I can`t clean anything";
        }

        public override string Wash()
        {
            IsClean = true;
            return $"I`m cat. I wash my face in the mornings and in the evenings";
        }

        public override string SendToBed()
        {
            IsAwake = false;
            return $"Cat went to sleep.";
        }
    }
}
