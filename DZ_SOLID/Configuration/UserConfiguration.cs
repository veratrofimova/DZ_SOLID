using DZ_SOLID.Interface;

namespace DZ_SOLID.Configuration
{
    public class UserConfiguration : IUserConfiguration, IMessage
    {

        private int _rangeStart;
        private int _rangeEnd;
        private int _countAttempts;

        public int RangeStart { get => _rangeStart; set { _rangeStart = value; } }
        public int RangeEnd { get => _rangeEnd; set { _rangeEnd = value; } }
        public int CountAttempts { get => _countAttempts; set { _countAttempts = value; } }

        public void GetConfig()
        {
            SendMessage("");
            SendMessage("\r\nВведите свой диапазон и количество попыток");
            _rangeStart = GetUserConfig("от: ");
            _rangeEnd = GetUserConfig("до: ");
            _countAttempts = GetUserConfig("Количество попыток: ");
        }

        private int GetUserConfig(string text)
        {
            int? value = null;
            do
            {
                Console.Write($"{text}");
                try
                {
                    value = int.Parse(Console.ReadLine());
                }
                catch
                {
                    SendMessage("Введите число в указанном диапазоне.");
                }
            }
            while (!value.HasValue);

            return value.Value;
        }

        public void SendMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}