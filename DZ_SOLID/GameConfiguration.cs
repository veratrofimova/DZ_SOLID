using DZ_SOLID.Interface;

namespace DZ_SOLID
{
    public class GameConfiguration : IGameConfiguration
    {
        private int _rangeStart;
        private int _rangeEnd;
        private int _countAttempts;
        private int _randomValue;

        private readonly IUserLevel _userLevel;

        public int RangeStart { get => _rangeStart; set { _rangeStart = value; } }
        public int RangeEnd { get => _rangeEnd; set { _rangeEnd = value;  } }
        public int CountAttempts { get => _countAttempts; set { _countAttempts = value;  } }
        public int RandomValue { get => _randomValue; set { _randomValue = value; } }

        public GameConfiguration(IUserLevel userLevel)
        {
            _userLevel = userLevel;
        }

        public void GetRandomValue()
        {                
            Random random = new Random();
            _randomValue =  random.Next(_rangeStart, _rangeEnd);            
        }

        public void GetConfiguration()
        {
            var сonfiguration = _userLevel.GetUserLevel();
            сonfiguration.GetConfig();

            _rangeStart = сonfiguration.RangeStart;
            _rangeEnd = сonfiguration.RangeEnd;
            _countAttempts = сonfiguration.CountAttempts;
        }
    }
}