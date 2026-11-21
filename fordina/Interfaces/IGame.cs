using fordina.Classes;

namespace fordina.Interfaces
{
    public interface IGame
    {
        string Name { get; }
        void Play(Team team);
    }
}
