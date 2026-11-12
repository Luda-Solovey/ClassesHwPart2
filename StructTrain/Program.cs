using System.Text;

namespace StructTrain
{
    internal class Program
    {
        /// <summary>
        /// Описати структуру з ім'ям Train, що містить такі поля: назву пункту призначення, номер поїзда, час відправлення. 
        /// Написати програму, яка виконує такі дії: введення з клавіатури даних до масиву, що складається з восьми елементів типу Train
        /// (записи мають бути впорядковані за номерами поїздів); 
        /// виведення на екран інформації про поїзд, номер якого введено з клавіатури (якщо таких поїздів немає, вивести відповідне повідомлення). 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Train[] trains =
            [
                new Train("Kyiv", 1, new DateTime(2024, 6, 1, 10, 23, 0)),
                new Train("Lviv", 8, new DateTime(2024, 6, 1, 12, 30, 0)),
                new Train("Odesa", 3, new DateTime(2024, 6, 1, 15, 45, 0)),
                new Train("Kharkiv", 6, new DateTime(2024, 6, 1, 18, 15, 0)),
                new Train("Dnipro", 7, new DateTime(2024, 6, 1, 20, 30, 0)),
                new Train("Zaporizhzhya", 4, new DateTime(2024, 6, 1, 22, 45, 0)),
                new Train("Vinnytsia", 5, new DateTime(2024, 6, 2, 0, 0, 0)),
                new Train("Chernivtsi", 2, new DateTime(2026, 11, 12, 10, 23, 0)),
            ];

            for (int i = 0; i < trains.Length - 1; i++)
            {
                for (int j = 0; j < trains.Length - 1 - i; j++)
                {
                    if (trains[j].Number > trains[j + 1].Number)
                    {
                        Train temp = trains[j];
                        trains[j] = trains[j + 1];
                        trains[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Введіть номер поїзда");
            string? enteredNumber = Console.ReadLine();

            //if (int.TryParse(enteredNumber, out int trainNumber))
            //{
            //    Train? foundTrain = null;
            //    foreach (var train in trains)
            //    {
            //        if (train.Number == trainNumber)
            //        {
            //            foundTrain = train;
            //            break;
            //        }
            //    }
            //    if (foundTrain.HasValue)
            //    {
            //        Console.WriteLine($"Інформація про поїзд: {foundTrain.Value}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Поїзд з таким номером не знайдено.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Введено некоректний номер поїзда.");
            //}

            if(enteredNumber is not null)
            {
                if(int.TryParse(enteredNumber, out int parcedNumber))
                {
                    foreach (var train in trains)
                    {
                        if (train.Number == parcedNumber)
                        {
                            Console.WriteLine($"Інформація про поїзд: номер {train.Number}, пункт призначення {train.Destination}, час відправлення {train.DepartureTime}");
                            return;
                        }
                    }
                    Console.WriteLine("Невірно введений номер поїзда.");
                }
            }

        }
    }
}
