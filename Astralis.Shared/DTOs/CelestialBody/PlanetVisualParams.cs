namespace Astralis.Shared.DTOs
{
    public class PlanetVisualParams
    {
        public int ShaderType { get; set; }

        public string[] BiomeColors { get; set; } = new string[5];
        public string AtmosphereColor { get; set; } = "#3366ff";
        public string CloudColor { get; set; } = "#ffffff";

        public float WaterLevel { get; set; }
        public float SnowLevel { get; set; }
        public float TerrainScale { get; set; }
        public float TerrainRoughness { get; set; }
        public float BumpStrength { get; set; }

        public bool HasClouds { get; set; }
        public float CloudDensity { get; set; }
        public float CloudScale { get; set; }
        public float CloudDistortion { get; set; }

        public float GaseousDistortion { get; set; }
    }
}