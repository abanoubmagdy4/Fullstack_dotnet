using System;

namespace CALists
{
    class Program
    {
        static void Main(string[] args)
        {
            var Egypt = new Country { IsoCode = "EGY", Name = "EGYPT" };
            var Iraq = new Country { IsoCode = "IRQ", Name = " Iraq" };
            Country[] countriesArray = {
                Egypt, Iraq
             };

            List<Country> countries = new List<Country>();
            Print(countries);
            Console.WriteLine("=====================");
            countries.Add(new Country { IsoCode = "BRA", Name = "Brasil" });
            Print(countries);
            Console.WriteLine("=====================");
            countries.AddRange(countriesArray);
            Print(countries);

        }
        static void Print(List<Country> countries)
        {
            foreach (var country in countries)
            {
                Console.WriteLine(country);

            }
        }
        class Country
        {
            public string IsoCode { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {

                return $"{Name} ({IsoCode})";

            }
        }

    }
}
 
