namespace EnumVolodymyrTask
{
    public class Employee : Person
    {

        /// <summary>
        /// Але таке завдання для підтримання тонусу. Вам треба продумати і створити клас який описує Employee властивості - які ви зробите звичайними типами а які переліченнями 
        ///Чи є він одружений, по якій системі працює - контракт, ФОП чи на загальній ститемі, рейтинг працівника, відділ до якого належить, резидент/не резидент, 
        ///отримання зарплати - на карту, переказом, в конверті, статус - активний чи вже не працює, стать, володіння мовами
        /// </summary>
        /// <param name="args"></param>

        public bool IsMarried { get; set; }

        public WorkType WorkType { get; set; }

        public Rating Rating { get; set; }

        public bool IsResident { get; set; }

        public bool IsActive { get; set; }

        public List<LanguageSkills> LanguageSkillsList { get; set; }

        public Employee(string firstName, string lastName, string patronymic, Gender gender) 
            : base(firstName, lastName, patronymic, gender)
        {
            List<LanguageSkills> LanguageSkillsList = [LanguageSkills.Ukrainian];
        }

    }
}
