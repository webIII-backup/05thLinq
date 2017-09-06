namespace Linq.Models
{

    public class CityDistance
    {
        public string Country { get; set; }
        public string Name { get; set; }
        public int DistanceInKm { get; set; }

        public override string ToString()
        {
            return $"{Name} in {Country} at {DistanceInKm} km distance";
        }
    }
}