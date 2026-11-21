using fordina.Interfaces;

namespace fordina.Classes
{
    public class BigRaces
    {
        private Organizer _organizer;
        private List<IGame> _games = new List<IGame>();
        private List<Team> _teams = new List<Team>();

        public BigRaces(Organizer organizer)
        {
            _organizer = organizer;
        }

        public void AddGame(IGame game)
        {
            _games.Add(game);
        }

        public void AddTeam(Team team)
        {
            _teams.Add(team);
        }

        public void Show()
        {
            Console.WriteLine($"\nШоу «Большие Гонки» (Организатор: {_organizer.Name})\n");

            foreach (var team in _teams)
            {
                Console.WriteLine($"Выступает команда: {team.Country}");
                foreach (var game in _games)
                {
                    game.Play(team);
                }
                Console.WriteLine();
            }
        }
    }
}
