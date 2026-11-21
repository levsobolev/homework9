using fordina.Interfaces;

namespace fordina.Classes.Games
{
    public class Slide : IGame
    {
        public string Name { get { return "Горка"; } }

        public void Play(Team team)
        {
            Console.WriteLine($"Команда {team.Country} штурмует финальную скользкую вершину в игре \"{Name}\"");
        }
    }
}
