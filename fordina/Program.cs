using fordina.Classes;
using fordina.Interfaces;
using fordina.Classes.Games;

namespace fordina
{
    public class Program
    {
        public static void Task()
        {
            Console.WriteLine("На шоу Большие гонки собираются 4 команды из разных стран. В команде по 15\r\n" +
                "человек. Всего за одну игру команда проходит по 6 испытаний (6 разных игр). Будет\r\n" +
                "неинтересно, если каждый раз игры будут одинаковыми, поэтому каждый раз игры\r\nразные. Главный\r\n" +
                "организатор, Оливье Ганьян, добавляет новые игры. Необходимо правильно\r\n" +
                "организовать классы, чтобы класс передачи «Большие Гонки» не изменял свой\r\n" +
                "функционал, а добавлял новый. В консоли необходимо создать 4 команды: Россия,\r\n" +
                "Франция, Китай и Казахстан, и чтобы они сыграли в 6 игр.");

            Organizer olivier = new Organizer("Оливье Ганьян");

            BigRaces show = olivier.AddBigRaces();

            show.AddTeam(new Team("Россия"));
            show.AddTeam(new Team("Франция"));
            show.AddTeam(new Team("Китай"));
            show.AddTeam(new Team("Казахстан"));

            var standardGames = new List<IGame>
            {
                new Beach(),
                new MouseTrap(),
                new Sea(),
                new Fishing(),
                new Postmen(),
                new Slide()
            };
            olivier.AddGames(standardGames);

            olivier.AddGame(new ObstacleMaze());

            show.Show();

        }
        public static void Main(string[] args)
        {
            Task(); 
        }
    }
}
