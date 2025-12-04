namespace Astralis.Shared.DTOs
{
    public class DiscoveryFilterDto
    {
        public string? Title { get; set; }
        public int? DiscoveryStatusId { get; set; }
        public int? AliasStatusId { get; set; }
        public int? DiscoveryApprovalUserId { get; set; }
        public int? AliasApprovalUserId { get; set; }
    }
}