namespace DZ_SOLID.Interface
{
    /// <summary>
    /// Связь с пользователем
    /// </summary>
    public interface IMessage
    {
        /// <summary>
        /// Отправить сообщение
        /// </summary>
        /// <param name="message"></param>
        void SendMessage(string message);
    }
}