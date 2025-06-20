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
    }
}