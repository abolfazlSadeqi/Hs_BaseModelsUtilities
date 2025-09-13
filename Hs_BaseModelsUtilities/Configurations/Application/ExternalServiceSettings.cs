namespace Hs_BaseModelsUtilities.Configurations.Application
{
    /// <summary>
    /// Settings for external service integrations and microservices
    /// </summary>
    public class ExternalServiceSettings
    {
        public string ServiceName { get; set; } = "ExternalService"; // Service name
        public string BaseUrl { get; set; } = "http://localhost:6000"; // Base URL
        public string ApiKey { get; set; } = "YourApiKey"; // API key
        public int TimeoutSeconds { get; set; } = 30; // Request timeout
        public bool EnableRetries { get; set; } = true; // Enable retry on failure
        public int MaxRetryCount { get; set; } = 3; // Max retry attempts
        public bool EnableCircuitBreaker { get; set; } = true; // Enable circuit breaker
        public int CircuitBreakerFailureThreshold { get; set; } = 5; // Failure threshold for circuit breaker
        public int CircuitBreakerResetTimeoutSeconds { get; set; } = 60; // Reset timeout for circuit breaker
    }
}



