
namespace Astralis.Shared.DTOs
{
    public class DiscoveryFilterDto
    {
        public string? Title { get; set; }
        public int? DiscoveryStatusId { get; set; }
        public int? AliasStatusId { get; set; }
        public int? DiscoveryApprovalUserId { get; set; }
        public int? AliasApprovalUserId { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is DiscoveryFilterDto dto &&
                   Title == dto.Title &&
                   DiscoveryStatusId == dto.DiscoveryStatusId &&
                   AliasStatusId == dto.AliasStatusId &&
                   DiscoveryApprovalUserId == dto.DiscoveryApprovalUserId &&
                   AliasApprovalUserId == dto.AliasApprovalUserId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Title, DiscoveryStatusId, AliasStatusId, DiscoveryApprovalUserId, AliasApprovalUserId);
        }
    }
}