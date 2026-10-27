namespace ClassRoom
{
    public class GoodPupil : Pupil
    {
        public GoodPupil(string firstName, string lastName, string middleName)
            : base(firstName, lastName, middleName)
        {
        }

        public GoodPupil(string firstName, string lastName, string middleName, DateOnly dateOfBirthday, Passport passport)
        : base(firstName, lastName, middleName, dateOfBirthday, passport)
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
