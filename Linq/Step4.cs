using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Models;

namespace Linq
{
    public class Step4
    {
        public void Execute()
        {
            Console.WriteLine("\nStep 4: Linq Select, var en anonieme types\n");

            IEnumerable<Location> placesVisited = TravelOrganizer.PlacesVisited;
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // simpele transaformatie van collectie van int-s
            IEnumerable<int> newNumbers = numbers.Select(g => g + 1);
            PrintCollection("De gewijzigde lijst van getallen:", newNumbers);

            // transformatie van Location-s naar int-s
            IEnumerable<int> cityLengths = placesVisited.Select(c => c.City.Length);
            PrintCollection("Lengte van de namen van de steden:", cityLengths);

            // transformatie van Location-s naar CityDistance-s, object initializer
            IEnumerable<CityDistance> cityDistances = placesVisited.Select(
                     c => new CityDistance
                     {
                         Name = c.City,
                         Country = c.Country,
                         DistanceInKm = (int)(c.Distance * 1.61)
                     });

            PrintCollection("Afstanden in km:", cityDistances);
            Console.WriteLine();

            // transformatie naar een anoniem type met de props Name, Country en DistanceInKm
            var anonymousCities = placesVisited.Select(c => new
            {
                Name = c.City,
                c.Country,
                DistanceInKm = c.Distance * 1.61
            });
            PrintCollection("Anonieme types:", anonymousCities);
            Console.WriteLine();

            Console.WriteLine("Druk op enter om verder te gaan...");
            Console.ReadLine();
        }

        // generische methode PrintCities<T>
        public static void PrintCollection<T>(string title, IEnumerable<T> cities)
        {
            Console.WriteLine();
            Console.WriteLine($"----- {title} -----");
            if (!cities.Any())
                Console.WriteLine("geen steden...");
            else
                foreach (var c in cities)
                    Console.WriteLine(c);
            Console.WriteLine();
        }
    }
}
