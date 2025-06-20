using DZ_SOLID.Interface;

namespace DZ_SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добрый день!");
            Console.WriteLine("Поиграем в игру «Угадай число»? ");
            Console.WriteLine("Правила игры: Программа рандомно генерирует число, пользователь должен угадать это число. \r\nПри каждом вводе числа программа пишет больше или меньше отгадываемого. Количество попыток фиксировано");

            IUserLevel userLevel = new UserLevel();    
            IGameConfiguration configuration = new GameConfiguration(userLevel);
            IGameRules gameRules = new GameRules();
            IGame game = new Game(configuration, gameRules);

            char key;
            do
            {
                game.Run();

                key = Console.ReadKey().KeyChar;
            }
            while (key == '1');
        }
    }
}