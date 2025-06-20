namespace DZ_SOLID.Interface
{
    /// <summary>
    /// Параметры игры
    /// </summary>
    public interface IGameConfiguration
    {
        int RangeStart { get; }
        int RangeEnd { get; }
        int CountAttempts { get; }
        int RandomValue { get; }

        /// <summary>
        /// Задать настройки для игры
        /// </summary>
        void GetConfiguration();

        /// <summary>
        /// Получить значение для игры
        /// </summary>
        void GetRandomValue();
    }
}