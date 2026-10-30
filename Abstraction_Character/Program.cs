using System.Text;

namespace Abstraction_Character
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Character dolphin = new Dolphin("Dol");
            Character parrot = new Parrot("Kesha");
            Character cat = new Cat("Barsik");
            Character dog = new Dog("Djina");

            Character[] characters = [dolphin, cat, dog, parrot];

            foreach (var character in characters)
            {
                Console.WriteLine(character.Name);
                // Показуємо меню доступної кожній тварикі їжі
                Console.WriteLine("Feed pet. Availiable Food:");
                for (int i = 0; i < character.AvailiableFood.Count; i++)
                {
                    Console.WriteLine($"{i + 1} - {character.AvailiableFood[i]}");
                }

                //отримуємо введене користувачем значення та валідуємо його
                int choosenValue;
                while (true)
                {
                    Console.WriteLine("Оберіть їжу (треба ввести номер обраної їжі). Або введіть 'exit' для виходу.");

                    string? enteredValue = Console.ReadLine();

                    //перевірка на 'exit'
                    if (enteredValue?.ToUpper() == "EXIT")
                    {
                        Console.WriteLine("Програма завершена користувачем.");
                        return;
                    }

                    //перевіряємо валідність
                    if (int.TryParse(enteredValue, out choosenValue) &&
                        choosenValue >=1 &&
                        choosenValue <= character.AvailiableFood.Count)
                    {
                        break;
                    }

                    Console.WriteLine("Введене не правильне значення. Введіть значення (цифру) з запропонованих варіантів");
                }

                character.PassHour();
                Console.WriteLine(character.GiveInformationAboutCurrentState());
                character.Feed(character.AvailiableFood[choosenValue - 1]);
                Console.WriteLine(character.GiveInformationAboutCurrentState());
                character.Play(10);
                Console.WriteLine(character.GiveInformationAboutCurrentState());
                character.Clean();
                Console.WriteLine(character.GiveInformationAboutCurrentState());
                character.SendToBed();
                Console.WriteLine(character.GiveInformationAboutCurrentState());
                character.SendToBed();
                Console.WriteLine(new string('*', 30));
            }

            Console.WriteLine(new string('*', 50));

            var petList = characters.ToList<Character>();
            MyPets myPets = new();

            //будемо всіх, якщо хтось спить
            Console.WriteLine("Якщо хтось спить - будемо");
            myPets.WakeUpPet(petList);

            foreach (var pet in petList)
            {
                Console.WriteLine($"Pet {pet.Name} IsAwake is {pet.IsAwake}");
            }

            //відправляємо всіх спати
            Console.WriteLine("Вкладаємо всіх спати");
            myPets.PutToBad(petList);
            foreach (var pet in petList)
            {
                Console.WriteLine($"Pet {pet.Name} IsAwake is {pet.IsAwake}");
            }

        }
    }
}
