namespace DZ_SOLID.Interface
{
    /// <summary>
    /// Уровень сложность
    /// </summary>
    public interface IUserLevel
    {
        /// <summary>
        /// Получить уровень сложности
        /// </summary>
        /// <returns></returns>
        IUserConfiguration GetUserLevel();
    }
}