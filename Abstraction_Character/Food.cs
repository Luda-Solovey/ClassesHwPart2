namespace Abstraction_Character
{
    public class Food(FoodTypes food)
    {
        public FoodTypes FoodToEat { get; } = food;

        public int CaloriesRate { get; } = food switch
        {
            FoodTypes.Algae => 30,
            FoodTypes.Grain => 50,
            FoodTypes.Fish => 60,
            FoodTypes.Bone => 70,
            FoodTypes.CatFood => 80,
            FoodTypes.DogFood => 90,
            FoodTypes.Beef => 130,
            _ => 0
        };
    }
}
