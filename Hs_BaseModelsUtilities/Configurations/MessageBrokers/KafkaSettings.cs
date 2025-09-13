namespace Hs_BaseModelsUtilities.Configurations.MessageBrokers
{
    /// <summary>
    /// Kafka messaging configuration
    /// </summary>
    public class KafkaSettings
    {
        public string BootstrapServers { get; set; } = "localhost:9092"; // Kafka bootstrap servers
        public string[] Topics { get; set; } = new[] { "default-topic" }; // Kafka topics
        public string ConsumerGroup { get; set; } = "default-group"; // Consumer group ID
        public int RetryBackoffMs { get; set; } = 500; // Retry backoff in milliseconds
    }
}



