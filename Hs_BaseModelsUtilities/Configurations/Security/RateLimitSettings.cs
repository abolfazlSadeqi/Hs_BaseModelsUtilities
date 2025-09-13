namespace Hs_BaseModelsUtilities.Configurations.Security
{
    /// <summary>
    /// API rate limiting and throttling settings
    /// </summary>
    public class RateLimitSettings
    {
        public int MaxRequestsPerMinute { get; set; } = 60; // Max requests per minute
        public int MaxRequestsPerHour { get; set; } = 1000; // Max requests per hour
        public int MaxRequestsPerDay { get; set; } = 10000; // Max requests per day
        public bool EnableGlobalRateLimit { get; set; } = true; // Enable global rate limiting
        public bool EnablePerUserRateLimit { get; set; } = true; // Enable per-user rate limiting
        public bool EnableBurstHandling { get; set; } = true; // Enable burst handling
    }
}



