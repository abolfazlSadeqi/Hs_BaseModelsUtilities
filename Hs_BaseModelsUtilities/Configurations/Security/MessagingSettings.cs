namespace Hs_BaseModelsUtilities.Configurations.Security
{
    /// <summary>
    /// MassTransit / RabbitMQ configuration
    /// </summary>
    public class MessagingSettings
    {
        public string Host { get; set; } = "localhost"; // RabbitMQ host
        public int Port { get; set; } = 5672; // Port
        public string VirtualHost { get; set; } = "/"; // Virtual host
        public string UserName { get; set; } = "guest"; // Username
        public string Password { get; set; } = "guest"; // Password
        public bool UseSsl { get; set; } = false; // Use SSL

        public string DefaultExchange { get; set; } = "default-exchange"; // Default exchange
        public string DefaultQueue { get; set; } = "default-queue"; // Default queue
        public string RetryQueueSuffix { get; set; } = ".retry"; // Retry queue suffix
        public string DeadLetterQueueSuffix { get; set; } = ".dlq"; // Dead letter queue suffix

        public int RetryCount { get; set; } = 5; // Retry attempts
        public int RetryIntervalSeconds { get; set; } = 30; // Retry interval seconds
        public int RetryIntervalMinutes { get; set; } = 5; // Retry interval minutes

        public ushort PrefetchCount { get; set; } = 16; // Prefetch count
        public int ConcurrentConsumers { get; set; } = 5; // Number of consumers

        public int MessageTimeToLiveSeconds { get; set; } = 3600; // Message TTL

        public bool EnableDeadLetter { get; set; } = true; // Enable dead letter handling
        public bool EnableRetry { get; set; } = true; // Enable retry

        public bool UseInMemoryTransport { get; set; } = false; // Use in-memory transport
        public bool EnableHealthChecks { get; set; } = true; // Enable MassTransit health checks
    }
}



