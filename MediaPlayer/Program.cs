namespace MediaPlayer
{
    internal class Program
    {
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
