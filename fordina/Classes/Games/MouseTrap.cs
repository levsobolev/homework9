using fordina.Interfaces;

namespace fordina.Classes.Games
{
    public class MouseTrap : IGame
    {
        public string Name {  get{ return "Мышеловка"; }}

        public void Play(Team team)
        {
            Console.WriteLine($"Команда {team.Country} проходит игру \"{Name}\", уворачиваясь от гигантских ловушек");
        }
    }
}
