namespace Hs_BaseModelsUtilities.Configurations.Application
{
   
    /// API versioning configuration
    /// </summary>
    public class ApiVersioningSettings
    {
        public string DefaultVersion { get; set; } = "1.0"; // Default API version
        public bool ReportApiVersions { get; set; } = true; // Report versions in response headers
        public bool AssumeDefaultWhenUnspecified { get; set; } = true; // Assume default version if unspecified
    }
}



