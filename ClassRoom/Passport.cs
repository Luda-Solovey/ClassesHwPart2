namespace ClassRoom
{
    public class Passport
    {
        public string Seria { get; }

        public int Number { get; }

        public DateOnly DateOfIssue { get;}

        public Passport(string seria, int number, DateOnly dataOfIssue)
        {
            Seria = seria;
            Number = number;
            DateOfIssue = DateOfIssue;
        }
    }
}
