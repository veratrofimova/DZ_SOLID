using DZ_SOLID.Enum;
using DZ_SOLID.Interface;

namespace DZ_SOLID
{
    public class GameRules : IGameRules, IMessage
    {
        public int GetGuessValue(int rangeStart, int rangeEnd)
        {
            int value = 0;
            bool isValueParse = false;
            do
            {
                SendMessage($"Введите число: ");

                try
                {
                    isValueParse = int.TryParse(Console.ReadLine(), out value);
                }
                catch
                {
                    SendMessage("Введите число в указанном диапазоне");
                }
            }
            while (!isValueParse);

            return value;
        }

        public ComparisonResult CheckValue(int randomValue, int valueUser)
        {            
            int compare = randomValue.CompareTo(valueUser);
            
            return compare == 0 ? ComparisonResult.Equals
                : compare == -1 ? ComparisonResult.Bigger
                : ComparisonResult.Smaller;            
        }

        public bool CheckAttemptUser(ref int attemptUser)
        {
            SendMessage($"\r\nОсталось попыток: {attemptUser}");

            if (attemptUser == 0)
            {
                SendMessage("Вы израсходовали все попытки");
                SendMessage("Game over!\r\n");
                SendMessage("\r\nХотите реванш? нажмите - 1, для выхода - 0");
                return false;
            }

            attemptUser--;
            return true;
        }

        public void SendMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}