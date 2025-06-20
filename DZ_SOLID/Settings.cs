using DZ_SOLID.Interface;

namespace DZ_SOLID
{
    public class Settings : ISettings
    {
        public int RangeStart { get; private set; }
        public int RangeEnd { get; private set; }
        public int CountAttempts { get; private set; }

        /// <summary>
        /// Параметры игры
        /// </summary>
        public Settings(int rangeStart, int rangeEnd, int countAttempts)
        {
            RangeStart = rangeStart;
            RangeEnd = rangeEnd;
            CountAttempts = countAttempts;
        }
    }
}
