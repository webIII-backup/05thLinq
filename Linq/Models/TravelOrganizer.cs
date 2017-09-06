using System.Collections.Generic;

namespace Linq.Models
{
    public static class TravelOrganizer
    {
        // list of places visited and their distance to Seattle
        public static IEnumerable<Location> PlacesVisited
        {
            get
            {
                return new List<Location>{
                                        new Location { City="London", Distance=4789, Country="UK" },
                                        new Location { City="Amsterdam", Distance=4869, Country="Netherland" },
                                        new Location { City="San Francisco", Distance=684, Country="USA" },
                                        new Location { City="Las Vegas", Distance=872, Country="USA" },
                                        new Location { City="Boston", Distance=2488, Country="USA" },
                                        new Location { City="Raleigh", Distance=2363, Country="USA" },
                                        new Location { City="Chicago", Distance=1733, Country="USA" },
                                        new Location { City="Charleston", Distance=2421, Country="USA" },
                                        new Location { City="Helsinki", Distance=4771, Country="Finland" },
                                        new Location { City="Nice", Distance=5428, Country="France" },
                                        new Location { City="Dublin", Distance=4527, Country="Ireland" }
                                    };
            }
        }
    }
}