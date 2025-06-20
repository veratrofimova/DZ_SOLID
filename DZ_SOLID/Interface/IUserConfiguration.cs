namespace DZ_SOLID.Interface
{
    /// <summary>
    /// Получение конфигурации игры из настроек
    /// </summary>
    public interface IUserConfiguration
    {
        /// <summary>
        /// Получение данных из конфига
        /// </summary>
        Settings GetConfig();
    }
}