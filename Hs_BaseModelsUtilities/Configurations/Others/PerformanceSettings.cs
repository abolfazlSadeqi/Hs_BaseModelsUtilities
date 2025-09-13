namespace Hs_BaseModelsUtilities.Configurations.Others
{
    /// <summary>
    /// Performance tuning and response caching
    /// </summary>
    public class PerformanceSettings
    {
        public bool EnableResponseCaching { get; set; } = true; // Enable response caching
        public int MaxRequestSizeBytes { get; set; } = 10485760; // Maximum request size
        public string CompressionLevel { get; set; } = "Optimal"; // Response compression level
    }
}



