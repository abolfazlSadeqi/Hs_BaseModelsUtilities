using System.Collections.Generic;

namespace Hs_BaseModelsUtilities.Configurations.Others
{
    /// <summary>
    /// Feature flag settings to enable/disable features dynamically
    /// </summary>
    public class FeatureFlagSettings
    {
        public bool EnableExperimental { get; set; } = false; // Experimental features
        public bool EnableBeta { get; set; } = true; // Beta features
        public bool EnableInternal { get; set; } = false; // Internal features
        public bool EnableReleaseCandidate { get; set; } = true; // Release candidate features

        public Dictionary<string, bool> CustomFlags { get; set; } = new()
        {
            { "Feature_X", true }, // Custom feature X
            { "Feature_Y", false } // Custom feature Y
        };
    }
}



