using DZ_SOLID.Interface;

namespace DZ_SOLID.Configuration
{
    public class UserConfiguration : IUserConfiguration, IMessage
    {
        public Settings GetConfig()
        {
            SendMessage("");
            SendMessage("\r\nВведите свой диапазон и количество попыток");
            int rangeStart = GetUserConfig("от: ");
            int rangeEnd = GetUserConfig("до: ");
            int countAttempts = GetUserConfig("Количество попыток: ");

            return new Settings(rangeStart, rangeEnd, countAttempts);
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