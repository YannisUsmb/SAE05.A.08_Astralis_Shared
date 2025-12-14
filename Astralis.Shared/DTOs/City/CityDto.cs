
namespace Astralis.Shared.DTOs
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string PostCode { get; set; } = null!;
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        // Country Properties.
        public int CountryId { get; set; }
        public string CountryName { get; set; } = null!;

        public override bool Equals(object? obj)
        {
            return obj is CityDto dto &&
                   Id == dto.Id &&
                   Name == dto.Name &&
                   PostCode == dto.PostCode &&
                   Latitude == dto.Latitude &&
                   Longitude == dto.Longitude &&
                   CountryId == dto.CountryId &&
                   CountryName == dto.CountryName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, PostCode, Latitude, Longitude, CountryId, CountryName);
        }
    }
}
