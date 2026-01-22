using System.Text.Json.Serialization;

namespace Astralis.Shared.DTOs
{
    public class PredictionResultDto
    {
        [JsonPropertyName("filename")]
        public string Filename { get; set; } = string.Empty;

        [JsonPropertyName("predicted_class")]
        public string Prediction { get; set; } = string.Empty;

        [JsonPropertyName("confidence_score")]
        public double Confidence { get; set; }

        [JsonPropertyName("model_version")]
        public string? ModelVersion { get; set; }
    }
}