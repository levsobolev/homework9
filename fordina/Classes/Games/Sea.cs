using fordina.Interfaces;

namespace fordina.Classes.Games
{
    public class Sea : IGame
    {
        public string Name { get { return "Море"; } }

        public void Play(Team team)
        {
            Console.WriteLine($"Команда {team.Country} проходит игру \"{Name}\", преодолевая водные препятствия");
        }
    }
}
