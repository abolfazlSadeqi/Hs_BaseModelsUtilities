namespace Hs_BaseModelsUtilities.Configurations.DB
{
    /// <summary>
    /// Redis cache configuration
    /// </summary>
    public class RedisSettings
    {
        public string ConnectionString { get; set; } = "localhost:6379"; // Redis connection string
        public int DefaultExpirationSeconds { get; set; } = 3600; // Default cache expiration (1 hour)
        public int ShortExpirationSeconds { get; set; } = 300; // Short cache expiration (5 minutes)
        public int LongExpirationSeconds { get; set; } = 86400; // Long cache expiration (1 day)
        public string InstanceName { get; set; } = "MyAppRedis"; // Redis instance name
        public bool EnableCompression { get; set; } = true; // Enable data compression
        public bool EnableDistributedCache { get; set; } = true; // Enable distributed cache

    }
}



