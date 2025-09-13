namespace Hs_BaseModelsUtilities.Constants
{
    public static class RetryPolicy
    {
        public const int DefaultRetries = 3;
        public const int DefaultDelaySeconds = 5;
        public const int MaxRetries = 10;

        /// <summary>
        /// Validates and returns a retry count within allowed range.
        /// </summary>
        public static int GetValidRetries(int retries)
        {
            if (retries < 0) return 0;
            if (retries > MaxRetries) return MaxRetries;
            return retries;
        }

        /// <summary>
        /// Validates and returns a delay in seconds within allowed range.
        /// </summary>
        public static int GetValidDelay(int seconds)
        {
            if (seconds < 0) return 0;
            return seconds;
        }
    }


}
