namespace Hs_BaseModelsUtilities.Constants
{
   
    public static class WorkflowConstants
    {
        public const string DefaultQueue = "DefaultQueue";
        public const string HighPriorityQueue = "HighPriorityQueue";
        public const string RetryQueue = "RetryQueue";
        public const string DeadLetterQueue = "DeadLetterQueue";
        public const string RetryIntervalSeconds = "30";
        public const string RetryIntervalMinutes = "5";
        public const string RetryIntervalHours = "1";
        public const string RetryIntervalDays = "1";
        public const string CronEveryMinute = "* * * * *";
        public const string CronEveryHour = "0 * * * *";
        public const string CronDaily = "0 0 * * *";
        public const string CronWeekly = "0 0 * * 0";
        public const string CronMonthly = "0 0 1 * *";
        public const string JobCategorySystem = "System";
        public const string JobCategoryBackground = "Background";
        public const string JobCategoryRecurring = "Recurring";
        public const string JobCategoryScheduled = "Scheduled";
        public const string JobCategoryAdHoc = "AdHoc";
    }


}
