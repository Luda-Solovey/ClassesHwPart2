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
            ExcelentPupil excelentPupil = new("Luda", "Solovey", "Alex");
            //excelentPupil.GetFullInformation();

            GoodPupil goodPupil = new("Zenia", "Sol", "aaa");
            //goodPupil.GetFullInformation();

            Passport badPupilPassport = new Passport("AN", "8456927", new DateOnly(2016, 12,23 ));
            BadPupil badPupil = new("Illia", "Simonov", "Petrov", new DateOnly(1987, 12, 30),badPupilPassport);
            //badPupil.GetFullInformation();

            ClassRoom classRoom = new(excelentPupil, goodPupil, badPupil);

            foreach (var pupil in classRoom.Pupils)
            {
                pupil.Study();
                pupil.Read();
                pupil.Write();
                pupil.Relax();
            }
        }
    }
}
