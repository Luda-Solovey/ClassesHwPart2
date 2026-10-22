namespace ClassRoom
{
    internal class ClassRoom
    {
        //private Pupil[] pupils;

        public Pupil[] Pupils { get; }
        public ClassRoom(params Pupil[] pupils)
        {
            if (pupils.Length < 2 || pupils.Length > 4)
            {
                throw new ArgumentException("Кількість учнів повинна бути від 2 до 4");
            }
            Pupils = pupils;
        }
    }
}
