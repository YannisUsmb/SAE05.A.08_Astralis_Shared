namespace Astralis.Shared.DTOs
{
    public class PlanetVisualParams
    {
        // Type général pour guider le shader (0 = Terrestrial, 1 = Gazeuse, 2 = Soleil/Star si besoin)
        public int ShaderType { get; set; } 

        // --- Couleurs (Code Hex ou RGB) ---
        public string[] BiomeColors { get; set; } = new string[5]; // Océan, Plage, Terre, Montagne, Neige
        public string AtmosphereColor { get; set; } = "#3366ff";
        public string CloudColor { get; set; } = "#ffffff";

        // --- Paramètres du Terrain (Planet Shader) ---
        public float WaterLevel { get; set; } // ColorRamp Noir (Proportion Océan)
        public float SnowLevel { get; set; } // ColorRamp Blanc (Proportion Neige)
        public float TerrainScale { get; set; } // Noise Scale
        public float TerrainRoughness { get; set; } // Noise Roughness
        public float BumpStrength { get; set; } // Bump

        // --- Paramètres des Nuages (Clouds Shader) ---
        public bool HasClouds { get; set; }
        public float CloudDensity { get; set; } // ColorRamp Cloud
        public float CloudScale { get; set; }

        // --- Paramètres Gazeux (Pour Gas Giant / Neptune-like) ---
        public float GaseousDistortion { get; set; } // Noise Distortion
        public float GaseousSpeed { get; set; } // Animation speed
    }
}