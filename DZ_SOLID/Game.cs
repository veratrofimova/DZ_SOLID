using DZ_SOLID.Enum;
using DZ_SOLID.Interface;

namespace DZ_SOLID
{
    public class Game : IGame, IMessage
    {
        private readonly ISettings _settings;
        private readonly IGameRules _gameRules;
        private int _randomValue;

        public Game(ISettings settings, IGameRules gameRules) 
        {
            _settings = settings;
            _gameRules = gameRules;
            _randomValue = GetRandomValue(_settings.RangeStart, _settings.RangeEnd);
        }

        public void Run()
        {
            SendMessage("");
            SendMessage($"\r\nНачнем! Отгадайте число от {_settings.RangeStart} до {_settings.RangeEnd} за {_settings.CountAttempts} попытки(ок)");

            int attemptUser = _settings.CountAttempts;

            while (_gameRules.CheckAttemptUser(ref attemptUser))
            {
                int valueUser = _gameRules.GetGuessValue(_settings.RangeStart, _settings.RangeEnd);

                var result = _gameRules.CheckValue(_randomValue, valueUser);

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

        private int GetRandomValue(int rangeStart, int rangeEnd)
        {
            Random random = new Random();
            return random.Next(rangeStart, rangeEnd);
        }
    }
}