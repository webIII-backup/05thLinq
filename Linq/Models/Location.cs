namespace Linq.Models
{

    public class Location
    {
        public string Country { get; set; }
        public string City { get; set; }
        public int Distance { get; set; }
        public override string ToString()
        {
            return $"{City} in {Country} at {Distance} miles distance";
        }
    }
}
