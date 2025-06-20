using DZ_SOLID.Configuration;
using DZ_SOLID.Interface;

namespace DZ_SOLID
{
    public class UserLevel : IUserLevel
    {
        public IUserConfiguration GetUserLevel()
        {
            do
            {
                Console.WriteLine("\r\nЗадайте уровень сложности: \r\nновичок - 0, \r\nсредний уровень - 1, \r\nпрофессионал - 2, \r\nэксперт (пользовательские настройки) - 3");
                char key = Console.ReadKey().KeyChar;
                switch (key)
                {
                    case '0':
                        return new JunConfiguration();
                    case '1':
                        return new MidlConfiguration();
                    case '2':
                        return new ProfConfiguration();
                    case '3':
                        return new UserConfiguration();
                    default:
                        Console.WriteLine("\r\nУровень выбран не корректно. Повторите попытку\r\n");
                        break;
                }
            }
            while(true);
        }
    }
}
