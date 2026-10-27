using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction_Character
{
    internal class Parrot : Character
    {
        public override string Clean()
        {
            return $"I`m parrot. I clean my feathers";
        }

        public override string Feed()
        {
            return $"I`m parrot. I feed a small parrot";
        }

        public override string Play()
        {
            return $"I play with a small parrot";
        }

        public override string SendToBed()
        {
            return $"I send to bad a small parrot";
        }

        public override string Wash()
        {
            return $"I`m parrot. Sometimes I wash my body";
        }
    }
}
