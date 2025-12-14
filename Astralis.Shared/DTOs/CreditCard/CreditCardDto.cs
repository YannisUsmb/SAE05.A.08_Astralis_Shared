
namespace Astralis.Shared.DTOs
{
    public class CreditCardDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is CreditCardDto dto &&
                   Id == dto.Id &&
                   UserId == dto.UserId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, UserId);
        }
    }
}
