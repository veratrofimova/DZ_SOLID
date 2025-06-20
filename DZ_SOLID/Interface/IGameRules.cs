using DZ_SOLID.Enum;

namespace DZ_SOLID.Interface
{
    /// <summary>
    /// Правила игры
    /// </summary>
    public interface IGameRules
    {
        /// <summary>
        /// Получить искомое значение
        /// </summary>
        int GetGuessValue(int rangeStart, int rangeEnd);

        /// <summary>
        /// Сравнить пользовательское значение
        /// </summary>
        ComparisonResult CheckValue(int randomValue, int valueUser);

        /// <summary>
        /// Оставшиеся попытки
        /// </summary>
        /// <param name="attemptUser"></param>
        /// <returns></returns>
        bool CheckAttemptUser(ref int attemptUser);
    }
}