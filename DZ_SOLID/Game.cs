using DZ_SOLID.Enum;
using DZ_SOLID.Interface;

namespace DZ_SOLID
{
    public class Game : IGame, IMessage
    {
        private readonly IGameConfiguration _configuration;
        private readonly IGameRules _gameRules;

        public Game(IGameConfiguration configuration, IGameRules gameRules) 
        {
            _configuration = configuration;
            _gameRules = gameRules;
        }

        public void Run()
        {
            _configuration.GetConfiguration();
            _configuration.GetRandomValue();

            SendMessage("");
            SendMessage($"\r\nНачнем! Отгадайте число от {_configuration.RangeStart} до {_configuration.RangeEnd} за {_configuration.CountAttempts} попытки(ок)");

            int attemptUser = _configuration.CountAttempts;

            while (_gameRules.CheckAttemptUser(ref attemptUser))
            {
                int valueUser = _gameRules.GetGuessValue(_configuration.RangeStart, _configuration.RangeEnd);

                var result = _gameRules.CheckValue(_configuration.RandomValue, valueUser);

                switch (result)
                {
                    case ComparisonResult.Equals:
                        SendMessage($"\r\nПоздравляем, загаданное число {valueUser}. Вы победили!\r\n");
                        SendMessage("\r\nХотите повторить? нажмите - 1, для выхода - 0");
                        return;
                    case ComparisonResult.Bigger:
                        SendMessage($"Число {valueUser} больше загаданного числа");
                        break;
                    case ComparisonResult.Smaller:
                        SendMessage($"Число {valueUser} меньше загаданного числа");
                        break;
                    default:
                        break;
                }
            }
        }

        public void SendMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}