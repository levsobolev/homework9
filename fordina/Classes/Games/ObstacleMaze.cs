using fordina.Interfaces;

namespace fordina.Classes.Games
{
    public class ObstacleMaze : IGame
    {
        public string Name { get { return "Лабиринт с препятствиями"; } }

        public void Play(Team team)
        {
            Console.WriteLine($"Команда {team.Country} вслепую ищет выход в игре \"{Name}\"");
        }
    }
}
