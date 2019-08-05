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
            
            foreach(var country in countries)
                Console.WriteLine("{0,6} {1,15}",$"{country.Population}: ",country.Name);


            Console.ReadKey();
        }
    }
}
