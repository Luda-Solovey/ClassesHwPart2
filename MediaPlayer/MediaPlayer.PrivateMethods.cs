namespace MediaPlayer
{
    static partial class MediaPlayer
    {
        private static void ReadFile(string pathToFile)
        {
            Console.WriteLine("Reading file: " + pathToFile);
        }
        private static void LogAction(string action)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Action performed: " + action);
            Console.ResetColor();
        }
    }
}
