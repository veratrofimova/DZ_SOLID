using DZ_SOLID.Interface;
using System.Xml.Linq;

namespace DZ_SOLID.Configuration
{
    public class ProfConfiguration : IUserConfiguration
    {
        private int _rangeStart;
        private int _rangeEnd;
        private int _countAttempts;

        public int RangeStart { get => _rangeStart; set { _rangeStart = value; } }
        public int RangeEnd { get => _rangeEnd; set { _rangeEnd = value; } }
        public int CountAttempts { get => _countAttempts; set { _countAttempts = value; } }

        public void GetConfig()
        {
            string filePath = $"{AppContext.BaseDirectory}\\..\\..\\..\\Config\\ProfConfig.xml";

            if (!File.Exists(filePath))
                throw new Exception($"Файл конфигурации ProfConfig.xml не найден");

            var xmlData = File.ReadAllText(filePath);
            XDocument doc = XDocument.Parse(xmlData);

            _rangeStart = int.Parse(doc.Element("Config").Element("RangeStart").Value);
            _rangeEnd = int.Parse(doc.Element("Config").Element("RangeEnd").Value);
            _countAttempts = int.Parse(doc.Element("Config").Element("CountAttempts").Value);
        }
    }
}