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
            HappinessLevel = 10;
            IsClean = true;
            IsAwake = true;
        }

        public abstract List<FoodTypes> AvailiableFood { get; }

        public string Name { get; }

        public int NumbersOfDaysLived { get; set; }

        public int HappinessLevel { get; set; }

        public int HungerLevel { get; set; }

        public bool IsAwake { get; set; }

        public bool IsClean { get; set; }

        public bool PlayedThisHour { get; set; }

        public virtual void PassHour()
        {
            HungerLevel += 100;
            if (!PlayedThisHour)
            {
                HappinessLevel--;
            }

            PlayedThisHour = false;
        }

        public virtual void Feed(FoodTypes food)
        {
            Food foodObject = new(food);

            if (HungerLevel > 0)
            {
                HungerLevel -= foodObject.CaloriesRate;
            }
        }

        public virtual void Play(int duration) //to do
        {
            PlayedThisHour = true;
            HappinessLevel += duration / 5; // make formula
        }

        public abstract void Clean(); //They cleaned up after me.  for cat and dog

        public virtual void Wash()
        {
            IsClean = true;
        }

        public virtual void SendToBed()
        {
            IsAwake = false;
        }

        public virtual string GiveInformationAboutCurrentState()
        {
            return $"I`m {(IsClean ? "clean" : "dirty")}, I`m {(IsAwake ? "staying awake" : "sleeping")}, my hunger level equals {HungerLevel}, my happines level {HappinessLevel}";
        }

        public abstract void Speek();

        public abstract void DoActivity();
    }
}
