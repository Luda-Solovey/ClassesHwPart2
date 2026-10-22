namespace Invoice
{
    public class Invoice
    {
        private readonly int account;
        private readonly string customer;
        private readonly string provider;

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public required string Article { get; init; }
        public required int Quantity { get; init; }

        private const decimal VatRate = 0.2m; // 20% VAT

        public decimal GetPrice()
        {
            decimal price = 0;
            switch (Article)
            {
                case "Computer":
                    price = 100.0m;
                    break;
                case "Monitor":
                    price = 20.0m;
                    break;
                case "Keyboard":
                    price = 30.0m;
                    break;
                case "Notebook":
                    price = 120.0m;
                    break;
                default:
                    throw new ArgumentException("Invalid article");
            }
            decimal total = price * Quantity;
            return total;
        }

        public decimal GetPriceWithOutPdv()
        {
            decimal price = GetPrice();
            decimal priceWithoutPdv = price * (1 - VatRate);
            return priceWithoutPdv;
        }

        public void ShowInvoice()
        {
            Console.WriteLine($"Account: {account}");
            Console.WriteLine($"Customer: {customer}");
            Console.WriteLine($"Provider: {provider}");
            Console.WriteLine($"Article: {Article}");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Total Price: {GetPrice()}");
            Console.WriteLine($"Price without PDV: {GetPriceWithOutPdv()}");
        }
    }
}
