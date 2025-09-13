namespace Hs_BaseModelsUtilities.Configurations.Security
{
    /// <summary>
    /// CORS settings for API
    /// </summary>
    public class CorsSettings
    {
        public string[] AllowedOrigins { get; set; } = { "*" }; // Allowed origins
        public string[] AllowedMethods { get; set; } = { "GET", "POST", "PUT", "DELETE" }; // Allowed HTTP methods
        public string[] AllowedHeaders { get; set; } = { "Content-Type", "Authorization" }; // Allowed headers
        public bool AllowCredentials { get; set; } = true; // Allow credentials
    }
}



