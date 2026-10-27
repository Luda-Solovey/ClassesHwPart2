using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction_Character
{
    internal class Dog : Character
    {
        public override string Clean()
        {
            return $"I`m dog. I can`t clean anything";
        }

        public override string Feed()
        {
            return $"I`m dog. I feed a little puppy";
        }

        public override string Play()
        {
            return $"I play with a little puppy";
        }

        public override string SendToBed()
        {
            return $"I send to bad a little puppy";
        }

        public override string Wash()
        {
            return $"I`m dog. I don`t wash my body";
        }
    }
}
