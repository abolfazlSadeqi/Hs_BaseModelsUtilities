using Hs_BaseModelsUtilities.Exceptions.Base;
using System.Net;

namespace Hs_BaseModelsUtilities.Exceptions.AuthSecurityExceptions
{

    /// <summary>
    /// Thrown when a token is invalid.
    /// </summary>
    public class InvalidTokenException : AppException
    {
        public InvalidTokenException()
            : base("Invalid authentication token.", "INVALID_TOKEN", HttpStatusCode.Unauthorized) { }
        public InvalidTokenException(string message) : base(message) { }
        public InvalidTokenException(string message, string errorCode, HttpStatusCode statusCode)
            : base(message, errorCode, statusCode) { }
    }
}
