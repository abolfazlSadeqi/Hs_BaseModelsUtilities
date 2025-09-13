namespace Hs_BaseModelsUtilities.Configurations.Others
{
    /// <summary>
    /// Health check endpoints and intervals
    /// </summary>
    public class HealthCheckSettings
    {
        public string[] Endpoints { get; set; } = new[] { "/health" }; // Health endpoints
        public int CheckIntervalSeconds { get; set; } = 30; // Interval between checks
        public bool EnableLiveness { get; set; } = true; // Enable liveness probe
        public bool EnableReadiness { get; set; } = true; // Enable readiness probe
    }
}



