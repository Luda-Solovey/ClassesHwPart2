namespace Invoice
{
    public class Program
    {
        /// <summary>
        /// Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
        ///Потрібно: Створити клас Invoice.У тілі класу створити три поля int account, string customer, string provider, 
        ///які мають бути проініціалізовані один раз(при створенні екземпляра даного класу) без можливості їхньої подальшої зміни.
        ///У тілі класу створити два закриті поля string article, int quantity Створити метод розрахунку вартості замовлення з ПДВ та без ПДВ.
        ///Написати програму, яка виводить на екран суму оплати замовленого товару з ПДВ чи без ПДВ.
        /// </summary>
        /// 
        static void Main(string[] args)
        {
            Invoice invoice1 = new Invoice(1, "Solovey", "Kashtan")
            {
                Article = "Computer",
                Quantity = 2
            };

            invoice1.GetPrice();

            Console.WriteLine($"Invoice info: ");
            invoice1.ShowInvoice();
        }
    }
}
