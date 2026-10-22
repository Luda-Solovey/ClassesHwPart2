namespace DocumentWorkerApp
{
    internal class DocumentWorker
    {
        //public string Document { get; set; }

        public virtual void OpenDocument()
        {
            Console.WriteLine($"Документ відкритий");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine($"Документ відредаговано");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine($"Документ збережено у старому форматі, збереження в інших форматах є у версії Експерт");
        }
    }
}
