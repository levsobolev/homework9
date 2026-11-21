using fordina.Interfaces;

namespace fordina.Classes.Games
{
    public class Beach : IGame
    {
        public string Name { get { return "Пляж"; } }

        public void Play(Team team)
        {
            Console.WriteLine($"Команда {team.Country} проходит игру \"{Name}\" на горячем песке");
        }
    }
}
