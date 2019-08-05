using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = "C:\\PopByLargest.csv";
            var reader = new CsvReader(filePath);

            var countries = reader.ReadFirstNCountries(10);
            var allCountries = reader.ReadAllCountries();

            Country liliput = new Country("Lilliput", "LIL", "Somewhere", 200000);
            int liliputIndex = allCountries.FindIndex(x=>x.Population <2000000);

            allCountries.Insert(liliputIndex, liliput);
            allCountries.RemoveAt(liliputIndex);

            foreach(var country in countries)
                Console.WriteLine("{0,6} {1,15}",$"{country.Population}: ",country.Name);

            foreach(var country in allCountries)
                Console.WriteLine("{0,6} {1,15}", $"{country.Population}: ", country.Name);

            Console.ReadKey();
        }
    }
}
