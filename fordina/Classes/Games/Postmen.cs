using fordina.Interfaces;

namespace fordina.Classes.Games
{
    public class Postmen : IGame
    {
        public string Name { get { return "Почтальон"; } }

        public void Play(Team team)
        {
            Console.WriteLine($"Команда {team.Country} на скорость доставляет посылки в игре \"{Name}\"");
        }
    }
}
