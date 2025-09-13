namespace Hs_BaseModelsUtilities.Configurations.DB
{
    /// <summary>
    /// SQL Database connection and settings
    /// </summary>
    public class SqlDatabaseSettings
    {
        public string ConnectionString { get; set; } = "Server=localhost;Database=mydb;User Id=sa;Password=Your_password;"; // Primary connection string
        public int CommandTimeoutSeconds { get; set; } = 30; // Command timeout in seconds
        public bool EnableRetryOnFailure { get; set; } = true; // Enable retry on failure
        public int MaxRetryCount { get; set; } = 3; // Maximum retry attempts
        public int RetryDelaySeconds { get; set; } = 5; // Delay between retries
        public string FailoverConnectionString { get; set; } = ""; // Optional failover connection string
        public bool EnableLogging { get; set; } = true; // Enable query logging
        public bool EnableConnectionPooling { get; set; } = true; // Enable connection pooling

    }
}



