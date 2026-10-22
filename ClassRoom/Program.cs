namespace ClassRoom
{
    internal class Program
    {
        /// <summary>
        /// Поліморфізм та наслідування
        /// Створити клас, який представляє навчальний клас ClassRoom. Створіть клас учень Pupil. 
        /// У тілі класу створіть методи void Study(), void Read(), void Write(), void Relax(). 
        /// Створіть 3 похідні класу ExcelentPupil, GoodPupil, BadPupil від класу базового класу Pupil і перевизначте кожен із методів, залежно від успішності учня.
        /// Конструктор класу ClassRoom приймає аргументи типу Pupil, клас має складатися із 4 учнів.
        /// Передбачте можливість, що користувач може передати 2 або 3 аргументи. Виведіть інформацію про те, 
        /// як усі учні екземпляра класу ClassRoom вміють вчитися, читати, писати, відпочивати. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ExcelentPupil excelentPupil = new("Luda", "Solovey", "Alex", new DateOnly(1987, 03, 23));
            //excelentPupil.GetFullInformation();

            GoodPupil goodPupil = new("Zenia", "Sol", "aaa", new DateOnly(1980, 03, 23));
            //goodPupil.GetFullInformation();

            BadPupil badPupil = new("Illia", "Simonov", "Petrov", new DateOnly(1986, 05, 05), "АН", 457623, new DateOnly(2004, 06, 30));
            //badPupil.GetFullInformation();

            ClassRoom classRoom = new(excelentPupil, goodPupil, badPupil);

            foreach (var pupil in classRoom.Pupils)
            {
                pupil.GetFullInformation();
            }
        }
    }
}
