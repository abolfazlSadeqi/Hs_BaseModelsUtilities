using Hs_BaseModelsUtilities.Exceptions.Base;
using System.Net;

namespace Hs_BaseModelsUtilities.Exceptions.GeneralExceptions
{
    /// <summary>
    /// Thrown when rate limit is exceeded.
    /// </summary>
    public class RateLimitExceededException : AppException
    {
        public RateLimitExceededException()
            : base("Rate limit exceeded.", "RATE_LIMIT_EXCEEDED", (HttpStatusCode)429) { }
        public RateLimitExceededException(string message) : base(message) { }
        public RateLimitExceededException(string message, string errorCode, HttpStatusCode statusCode)
            : base(message, errorCode, statusCode) { }
    }
}
