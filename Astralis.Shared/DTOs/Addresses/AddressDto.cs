namespace Astralis.Shared.DTOs
{
    public class AddressDto
    {
        public int Id { get; set; }
        public string StreetNumber { get; set; } = null!;
        public string StreetAddress { get; set; } = null!;

        // City Info.
        public int CityId { get; set; }
        public string CityName { get; set; } = null!;
        public string PostCode { get; set; } = null!;

        // Country Info.
        public int CountryId { get; set; }
        public string CountryName { get; set; } = null!;
    }
}
