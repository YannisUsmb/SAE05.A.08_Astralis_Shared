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
    }
}
