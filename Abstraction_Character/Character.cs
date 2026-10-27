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
        public int NumbersOfDaysLived { get; set; }
        public int HappinessLevel { get; set; }

        public int HungerLevel { get; set; }

        public bool IsAwake { get; set; }

        public bool IsClean { get; set; }

        public abstract string Feed();

        public abstract string Play();

        public abstract string Clean();

        public abstract string Wash();

        public abstract string SendToBed();

        public string GiveInformationAboutCurrentState()
        {
            return $"I`m {(IsClean ? "clean" : "dirty")}, I`m {(IsAwake ? "staying awake" : "sleeping")}, my hunger level equals {HungerLevel}, my happines level {HappinessLevel}";
        }

    }
}
