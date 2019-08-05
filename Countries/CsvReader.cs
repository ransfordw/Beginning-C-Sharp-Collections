using System.Collections.Generic;
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

        public List<Country> ReadAllCountries()
        {
            var countries = new List<Country>();
            using (var streamReader = new StreamReader(_csvFilePath))
            {
                streamReader.ReadLine();
                string csvLine;
                while ((csvLine = streamReader.ReadLine()) != null)
                {
                    countries.Add(ReadCountryFromCsvLine(csvLine));
                }
                return countries;
            }

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
            string name;
            string code;
            string region;
            string popText;
            switch (parts.Length)
            {
                case 4:
                    name = parts[0];
                    code = parts[1];
                    region = parts[2];
                    popText = parts[3];
                    break;
                case 5:
                    name = parts[0] + ", "+ parts[1];
                    name = name.Replace("\"", null);
                    code = parts[2];
                    region = parts[3];
                    popText = parts[4];
                    break;
                default:
                    throw new System.Exception($"Can't parse country from csvLine: {csvLine}");
            }

            int.TryParse(popText, out int pop);
            return new Country(name, code, region, pop);
        }
    }
}
