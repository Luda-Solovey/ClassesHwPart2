namespace StructNotebook
{
    public struct Notebook(string model, string manufacturer, decimal price)
    {
        /// <summary>
        /// Створіть структуру з ім'ям – Notebook. Поля структури: модель, виробник, вартість. 
        /// У структурі має бути реалізований конструктор для ініціалізації полів та метод для виведення вмісту полів на екран.
        /// </summary>
        /// <param name="args"></param>
        

        public string Model { get; } = model;
        public string Manufacturer { get; } = manufacturer;
        public decimal Price { get; set; } = price;

        public readonly void DisplayInfo()
        {
            Console.WriteLine($"Модель: {Model}, Виробник: {Manufacturer}, Вартість: {Price}");
        }
    }
}
