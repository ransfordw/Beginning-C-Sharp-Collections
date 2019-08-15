using Countries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionarySnippets
{
    class Program
    {
        static void Main(string[] args)
        {
            var norway = new Country("Norway", "NOR", "Europe", 5282223);
            var finland = new Country("Finland", "FIN", "Europe", 5511303);

            var countries = new Dictionary<string, Country>
            {
                { norway.Code, norway },
                { finland.Code, finland }
            };

            bool exists = countries.TryGetValue("MUS", out Country country);
            if(exists)
                Console.WriteLine(country.Name);
            else
                Console.WriteLine("There is no country with the code MUS");


            foreach(KeyValuePair<string,Country> c in countries)
                Console.WriteLine(c.Value.Name);

            foreach(var singleCountry in countries.Values)
                Console.WriteLine(singleCountry.Name);

            Country selectedCountry = countries["NOR"];

            Console.WriteLine(selectedCountry.Name);

            Console.ReadKey();
        }
    }
}
