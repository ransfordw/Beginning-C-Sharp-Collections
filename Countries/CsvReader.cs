using System.IO;

namespace Countries
{
    public class CsvReader
    {
        private readonly string _csvFilePath;
        public CsvReader(string filePath)
        {
            _csvFilePath = filePath;
        }
        public Country[] ReadFirstNCountries(int numberOfCountries)
        {
            var countries = new Country[numberOfCountries];

            using (var streamReader = new StreamReader(_csvFilePath))
            {
                // read header line
                streamReader.ReadLine();

                for (int i = 0; i < numberOfCountries; i++)
                {
                    var csvLine = streamReader.ReadLine();
                    countries[i] = ReadCountryFromCsvLine(csvLine);
                }
            }

            return countries;
        }

        public Country ReadCountryFromCsvLine(string csvLine)
        {
            string[] parts = csvLine.Split(',');

            var name = parts[0];
            var code = parts[1];
            var region = parts[2];
            int pop = int.Parse(parts[3]);

            return new Country(name, code, region, pop);
        }
    }
}
