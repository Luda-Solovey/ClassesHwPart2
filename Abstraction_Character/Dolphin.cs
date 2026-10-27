namespace Abstraction_Character
{
    public class Dolphin : Character
    {
        public override string Clean()
        {
            return $"I`m dolphin. I can`t clean anything";
        }

        public override string Feed()
        {
            return $"I`m dolphin. I feed a little dolphin";
        }

        public override string Play()
        {
            return $"I play with a little dolphin";
        }

        public override string SendToBed()
        {
            return $"I send to bad a little dolphin";
        }

        public override string Wash()
        {
            return $"I`m dolphin. I wash my body all the time";
        }
    }
}
