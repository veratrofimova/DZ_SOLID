namespace DZ_SOLID.Interface
{
    /// <summary>
    /// Параметры игры
    /// </summary>
    public interface IGameConfiguration
    {
        /// <summary>
        /// Задать настройки для игры
        /// </summary>
        Settings GetConfiguration();

        /// <summary>
        /// Получить значение для игры
        /// </summary>
        int GetRandomValue(int rangeStart, int rangeEnd);
    }
}