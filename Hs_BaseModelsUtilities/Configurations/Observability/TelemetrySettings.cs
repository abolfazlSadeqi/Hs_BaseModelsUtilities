namespace Hs_BaseModelsUtilities.Configurations.Observability
{
    /// <summary>
    /// Telemetry, logging, metrics, and distributed tracing settings
    /// </summary>
    public class TelemetrySettings
    {
        public bool EnableLogging { get; set; } = true; // Enable application logging
        public string LogLevel { get; set; } = "Information"; // Log level (Trace, Debug, Info, Warning, Error, Critical)
        public bool EnableConsoleLogging { get; set; } = true; // Log to console
        public bool EnableFileLogging { get; set; } = true; // Log to files
        public string LogFolder { get; set; } = "/logs/"; // Log folder path
        public bool EnableMetrics { get; set; } = true; // Enable metrics collection
        public string MetricsEndpoint { get; set; } = "/metrics"; // Metrics endpoint path
        public bool EnableDistributedTracing { get; set; } = true; // Enable distributed tracing


    }
}



