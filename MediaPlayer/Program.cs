namespace MediaPlayer
{
    internal class Program
    {
        /// <summary>
        /// Завдання від мене - зробіть клас  MediaPlayer, розбийте його на дві частини - в одній частині методи Play(string fileName) Stop() Pause() Continue() 
        /// в іншій частині два приватних метода, які використовується в першій частині ReadFile(string pathToFile) - використовується в Play() також метод LogAction()
        /// - який виводить на консоль зеленим кольором що відбувлось Play/Stop/Pause/Continue
        /// Всі дії імітуйте через Console.WriteLine
        /// </summary>

        static void Main(string[] args)
        {
            MediaPlayer.Play("song.mp3");

            MediaPlayer.Stop();

            MediaPlayer.Pause();

            MediaPlayer.Continue();

            MediaPlayer.Play("video.mp4");
        }
    }
}
