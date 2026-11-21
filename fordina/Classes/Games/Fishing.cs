using fordina.Interfaces;

namespace fordina.Classes.Games
{
    public class Fishing : IGame
    {
        public string Name { get { return "Рыбалка"; } }

        public void Play(Team team)
        {
            Console.WriteLine($"Команда {team.Country} ловит бонусные очки в игре \"{Name}\"");
        }
    }
}
