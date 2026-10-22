namespace DocumentWorkerApp
{
    internal class ProDocumentWorker : DocumentWorker
    {
        public override void OpenDocument()
        {
            Console.WriteLine($"Документ відкритий у версії Про");
        }
        public override void EditDocument()
        {
            Console.WriteLine($"Редагування документа у версії Про");
        }
        public override void SaveDocument()
        {
            Console.WriteLine($"Збереження документа у версії Про");
        }
    }
}
