using DZ_SOLID.Interface;

namespace DZ_SOLID
{
    public class GameConfiguration : IGameConfiguration
    {
        private readonly IUserLevel _userLevel;

        public GameConfiguration(IUserLevel userLevel)
        {
            _userLevel = userLevel;
        }

        public int GetRandomValue(int rangeStart, int rangeEnd)
        {                
            Random random = new Random();
            return random.Next(rangeStart, rangeEnd);            
        }

        public Settings GetConfiguration()
        {
            var сonfiguration = _userLevel.GetUserLevel();
            return сonfiguration.GetConfig();
        }
    }
}