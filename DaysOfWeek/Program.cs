using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            foreach (var day in daysOfWeek)
               // Console.WriteLine(day);

            Console.Write($"Which day do you want to display?\n(For Example: Monday = 1) > ");
            var daySelection = int.Parse(Console.ReadLine());

            var chosenDay = daysOfWeek[daySelection - 1];
            Console.WriteLine($"That day is {chosenDay}");

            Console.ReadLine();
        }
    }
}
