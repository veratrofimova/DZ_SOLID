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

        public Settings GetConfiguration()
        {
            var сonfiguration = _userLevel.GetUserLevel();
            return сonfiguration.GetConfig();
        }
    }
}