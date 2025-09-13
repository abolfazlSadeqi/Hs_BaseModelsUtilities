using Hs_BaseModelsUtilities.Exceptions.Base;
using System.Net;

namespace Hs_BaseModelsUtilities.Exceptions.GeneralExceptions
{
    /// <summary>
    /// Thrown when an operation times out.
    /// </summary>
    public class TimeoutException : AppException
    {
        public TimeoutException()
            : base("Operation timed out.", "TIMEOUT", HttpStatusCode.RequestTimeout) { }
        public TimeoutException(string message) : base(message) { }
        public TimeoutException(string message, string errorCode, HttpStatusCode statusCode)
            : base(message, errorCode, statusCode) { }
    }
}
