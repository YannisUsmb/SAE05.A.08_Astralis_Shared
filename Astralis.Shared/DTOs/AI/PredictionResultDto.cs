namespace Astralis.Shared.DTOs
{
    public class PredictionResultDto
    {
        public string Filename { get; set; } = string.Empty;
        public string Prediction { get; set; } = string.Empty;
        public double Confidence { get; set; }
    }
}