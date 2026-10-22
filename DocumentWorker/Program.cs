using System.Text;

namespace DocumentWorkerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine($"Введіть ключ доступу");
            string? key = Console.ReadLine();

            DocumentWorker documentWorker;

            switch (key)
            {
                case "pro":
                    documentWorker = new ProDocumentWorker();
                    break;
                case "exp":
                    documentWorker = new ExpertDocumentWorker();
                    break;
                default:
                    documentWorker = new DocumentWorker();
                    break;
            }

            documentWorker.OpenDocument();
            documentWorker.EditDocument();
            documentWorker.SaveDocument();
        }
    }
}
