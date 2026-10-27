namespace ClassRoom
{
    public class Passport
    {
        public string Seria { get; set; }

        public string Number { get; set; }

        public DateOnly DateOfIssue { get; set; }

        public Passport(string seria, string number, DateOnly dataOfIssue)
        {
            Seria = seria;
            Number = number;
            DateOfIssue = DateOfIssue;
        }
    }
}
