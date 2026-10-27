using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction_Character
{
    public class Cat : Character
    {
        public override string Clean()
        {
            return $"I`m cat. I can`t clean anything";
        }

        public override string Feed()
        {
            return $"I`m cat. I feed a little kitten";
        }

        public override string Play()
        {
            return $"I play with a little kitten";
        }

        public override string SendToBed()
        {
            return $"I send to bad a little kitten";
        }

        public override string Wash()
        {
            return $"I`m cat. I wash my face in the mornings and in the evenings";
        }
    }
}
