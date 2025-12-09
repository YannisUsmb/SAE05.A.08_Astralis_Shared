namespace Astralis.Shared.DTOs
{
    public class CommandListDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public string CommandStatusLabel { get; set; } = null!;
        public int CountItems { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is CommandListDto dto &&
                   Id == dto.Id &&
                   Date == dto.Date &&
                   Total == dto.Total &&
                   CommandStatusLabel == dto.CommandStatusLabel &&
                   CountItems == dto.CountItems;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Date, Total, CommandStatusLabel, CountItems);
        }
    }
}
