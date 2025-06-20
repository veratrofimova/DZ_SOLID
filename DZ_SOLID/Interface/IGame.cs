namespace DZ_SOLID.Interface
{
    /// <summary>
    /// Возможности игры
    /// </summary>
    public interface IGame
    {      
        /// <summary>
        /// Запустить игру
        /// </summary>
        void Run();

        /// <summary>
        /// Отправить сообщение пользователю
        /// </summary>
        void SendMessage(string message);
    }
}