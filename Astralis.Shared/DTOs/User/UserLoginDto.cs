using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class UserLoginDto
    {
        [Required(ErrorMessage = "L'identifiant de connexion est requis.")]
        public string Identifier { get; set; } = null!;

        [Required(ErrorMessage = "Le mot de passe est requis.")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        public override bool Equals(object? obj)
        {
            return obj is UserLoginDto dto &&
                   Identifier == dto.Identifier &&
                   Password == dto.Password;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Identifier, Password);
        }
    }
}
