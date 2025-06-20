namespace DZ_SOLID.Interface
{
    /// <summary>
    /// Параметры игры
    /// </summary>
    public interface ISettings
    {
        int RangeStart { get; }
        int RangeEnd { get; }
        int CountAttempts { get; }
    }
}
