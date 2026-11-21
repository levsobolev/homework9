namespace fordina.Classes
{
    public class Team
    {
        public string Country { get; }
        public int MembersCount {  get; }

        public Team(string country, int membersCount = 15)
        {
            if (membersCount  != 15)
            {
                throw new ArgumentException("В команде доложно быть ровно 15 человек");
            }
            Country = country;
            MembersCount = membersCount;

        }
    }
}
