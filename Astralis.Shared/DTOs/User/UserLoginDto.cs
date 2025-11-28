using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class UserLoginDto
    {
        [Required(ErrorMessage = "The login identifier is required.")]
        public string Identifier { get; set; } = null!;

        [Required(ErrorMessage = "The password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
    }
}
