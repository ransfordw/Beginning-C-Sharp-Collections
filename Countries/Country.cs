using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries
{
    public class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Region { get; set; }
        public int Population { get; set; }
        public Country(string name, string code, string region, int popluation)
        {
            Name = name;
            Code = code;
            Region = region;
            Population = popluation;
        }
    }
}
