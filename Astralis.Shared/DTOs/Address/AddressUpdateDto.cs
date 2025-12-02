using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class AddressUpdateDto
    {
        [Required(ErrorMessage = "The address ID is required.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "The city ID is required.")]
        public int CityId { get; set; }

        [Required(ErrorMessage = "The street number is required.")]
        [StringLength(15, ErrorMessage = "The street number cannot be longer than 15 characters.")]
        public string StreetNumber { get; set; } = null!;

        [Required(ErrorMessage = "The street address is required.")]
        [StringLength(200, ErrorMessage = "The street address cannot be longer than 200 characters.")]
        public string StreetAddress { get; set; } = null!;
    }
}
