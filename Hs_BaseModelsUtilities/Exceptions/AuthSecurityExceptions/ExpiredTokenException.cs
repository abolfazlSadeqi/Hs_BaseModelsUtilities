using Hs_BaseModelsUtilities.Exceptions.Base;
using System.Net;

namespace Hs_BaseModelsUtilities.Exceptions.AuthSecurityExceptions
{
    /// <summary>
    /// Thrown when a token has expired.
    /// </summary>
    public class ExpiredTokenException : AppException
    {
        public ExpiredTokenException()
            : base("Authentication token has expired.", "EXPIRED_TOKEN", HttpStatusCode.Unauthorized) { }
        public ExpiredTokenException(string message) : base(message) { }
        public ExpiredTokenException(string message, string errorCode, HttpStatusCode statusCode)
            : base(message, errorCode, statusCode) { }
    }
}
