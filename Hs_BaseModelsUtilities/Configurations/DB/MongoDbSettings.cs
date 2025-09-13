namespace Hs_BaseModelsUtilities.Configurations.DB
{
    /// <summary>
    /// MongoDB connection and pool settings
    /// </summary>
    public class MongoDbSettings
    {
        public string ConnectionString { get; set; } = "mongodb://localhost:27017"; // MongoDB connection string
        public string DatabaseName { get; set; } = "MyMongoDb"; // Database name
        public bool EnableRetryWrites { get; set; } = true; // Enable retryable writes
        public int MaxConnectionPoolSize { get; set; } = 100; // Maximum connection pool size
        public int MinConnectionPoolSize { get; set; } = 10; // Minimum connection pool size
        public int SocketTimeoutSeconds { get; set; } = 30; // Socket timeout in seconds
        public int ConnectTimeoutSeconds { get; set; } = 10; // Connection timeout in seconds


    }
}



