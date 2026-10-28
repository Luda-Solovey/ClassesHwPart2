namespace Abstraction_Character
{
    /// <summary>
    /// Створити клас для гри догляд за твариною 
    ///є клас Character(Персонаж) в нього є такі методи - годувати, грати, прибирати, мити, відправляти спати, давати інформацію про поточний стан.
    ///Стан який його описує - рівень голоду, рівень щастя, к-ть прожитих днів днів), спить чи бодрствує брудний чи чистий.
    ///Продумайте які з метоюдів ми робимо астрактними, які звичайними а які віртуальними
    ///Далі класи наслідники - Dolphin, Cat, Dog, Parrot
    ///
    /// </summary>
    public abstract class Character
    {
        protected Character(string name)
        {
            Name = name;
            HappinessLevel = 5;
            HungerLevel = 0;
            NumbersOfDaysLived = 0;
            IsClean = true;
            IsAwake = true;
            PlayedThisHour = false;
        }

        public string Name { get; set; }
        public int NumbersOfDaysLived { get; set; } 
        public int HappinessLevel { get; set; }

        public int HungerLevel { get; set; }

        public bool IsAwake { get; set; }

        public bool IsClean { get; set; }

        public bool PlayedThisHour { get; set; }

        public virtual void PassHour()
        {
            HungerLevel++;
            if (!PlayedThisHour)
            {
                HappinessLevel--;
            }
        }

        public virtual void Feed()
        {
            if (HungerLevel > 0)
            {
                HungerLevel = 0;
            }
        }

        public virtual void Play()
        {
            PlayedThisHour = true;
            HappinessLevel++;
        }

        public abstract string Clean();

        public abstract string Wash();

        public virtual string SendToBed()
        {
            IsAwake = false;
            return $"Character went to sleep.";
        }

        public virtual string GiveInformationAboutCurrentState()
        {
            return $"I`m {(IsClean ? "clean" : "dirty")}, I`m {(IsAwake ? "staying awake" : "sleeping")}, my hunger level equals {HungerLevel}, my happines level {HappinessLevel}";
        }
    }
}
