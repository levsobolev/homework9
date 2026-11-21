using fordina.Interfaces;

namespace fordina.Classes
{
    public class Organizer
    {
        private BigRaces BigRaces { get; set; }
        public string Name { get; }
        
        public Organizer(string name)
        {
            Name = name;
        }

        public BigRaces AddBigRaces()
        {
            BigRaces bigRaces = new BigRaces(this);
            BigRaces = bigRaces;
            return bigRaces;
        }

        public void AddGame(IGame game)
        {
            BigRaces.AddGame(game);
        }

        public void AddGames(List<IGame> games)
        {
            foreach(var game in games)
            {
                BigRaces.AddGame(game);
            }
        }
    }
}
