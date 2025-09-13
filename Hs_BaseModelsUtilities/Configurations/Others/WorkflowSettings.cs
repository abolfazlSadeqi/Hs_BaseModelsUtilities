namespace Hs_BaseModelsUtilities.Configurations.Others
{
    /// <summary>
    /// Workflow / background job configuration
    /// </summary>
    public class WorkflowSettings
    {
        public string DefaultQueue { get; set; } = "DefaultQueue"; // Default job queue
        public string HighPriorityQueue { get; set; } = "HighPriorityQueue"; // High priority queue
        public string RetryQueue { get; set; } = "RetryQueue"; // Retry queue
        public string DeadLetterQueue { get; set; } = "DeadLetterQueue"; // Dead letter queue

        public int RetryIntervalSeconds { get; set; } = 30; // Retry interval seconds
        public int RetryIntervalMinutes { get; set; } = 5; // Retry interval minutes
        public int RetryIntervalHours { get; set; } = 1; // Retry interval hours
        public int RetryIntervalDays { get; set; } = 1; // Retry interval days

        public string CronEveryMinute { get; set; } = "* * * * *"; // Cron for every minute
        public string CronEveryHour { get; set; } = "0 * * * *"; // Cron for every hour
        public string CronDaily { get; set; } = "0 0 * * *"; // Daily cron
        public string CronWeekly { get; set; } = "0 0 * * 0"; // Weekly cron
        public string CronMonthly { get; set; } = "0 0 1 * *"; // Monthly cron

        public int MaxConcurrentJobs { get; set; } = 10; // Max concurrent jobs
        public int MaxRetriesPerJob { get; set; } = 5; // Max retries per job
        public bool EnableJobHistoryLogging { get; set; } = true; // Enable job history logging
    }
}



