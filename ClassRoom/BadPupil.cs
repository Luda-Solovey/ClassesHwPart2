using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoom
{
    internal class BadPupil : Pupil
    {
        public BadPupil(string firstName, string lastName, string middleName, DateOnly dateOfBirthday)
            : base(firstName, lastName, middleName, dateOfBirthday)
        {
        }

        public BadPupil(string firstName, string lastName, string middleName, DateOnly dateOfBirthday, string seriaPasport, int numberPassport, DateOnly dataPassportIssue)
        : base(firstName, lastName, middleName, dateOfBirthday, seriaPasport, numberPassport, dataPassportIssue)
        {
        }

        public override void Study()
        {
            Console.WriteLine($"I`m {FullName}. I`m an {this.GetType()}. I study");
        }
        public override void Read()
        {
            Console.WriteLine($"I`m {FullName}. I`m an {this.GetType()}. I read");
        }

        public override void Write()
        {
            Console.WriteLine($"I`m {FullName}. I`m an {this.GetType()}. I write");
        }

        public override void Relax()
        {
            Console.WriteLine($"I`m {FullName}. I`m an {this.GetType()}. I relax");
        }
    }
}
