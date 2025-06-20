namespace DZ_SOLID.Interface
{
    /// <summary>
    /// Получение конфигурации игры из настроек
    /// </summary>
    public interface IUserConfiguration
    {
        int RangeStart { get; }
        int RangeEnd { get; }
        int CountAttempts { get; }

        /// <summary>
        /// Получение данных из конфига
        /// </summary>
        void GetConfig();
    }
}