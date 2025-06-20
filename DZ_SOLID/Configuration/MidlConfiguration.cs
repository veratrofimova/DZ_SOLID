using DZ_SOLID.Interface;
using System.Xml.Linq;

namespace DZ_SOLID.Configuration
{
    public class MidlConfiguration : IUserConfiguration
    {
        public Settings GetConfig()
        {
            string filePath = $"{AppContext.BaseDirectory}\\..\\..\\..\\Config\\MidlConfig.xml";

            if (!File.Exists(filePath))
                throw new Exception($"Файл конфигурации MidlConfig.xml не найден");

            var xmlData = File.ReadAllText(filePath);
            XDocument doc = XDocument.Parse(xmlData);

            int rangeStart = int.Parse(doc.Element("Config").Element("RangeStart").Value);
            int rangeEnd = int.Parse(doc.Element("Config").Element("RangeEnd").Value);
            int countAttempts = int.Parse(doc.Element("Config").Element("CountAttempts").Value);

            return new Settings(rangeStart, rangeEnd, countAttempts);
        }
    }
}