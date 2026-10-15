namespace MediaPlayer
{
    static partial class MediaPlayer
    {
        public static void Play(string fileName)
        {
            ReadFile(fileName);
            LogAction(nameof(Play));
        }

        public static void Pause()
        {
            LogAction(nameof(Pause));
        }

        public static void Stop()
        {
            LogAction(nameof(Stop));
        }

        public static void Continue()
        {
            LogAction(nameof(Continue));
        }
    }
}
