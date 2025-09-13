using Hs_BaseModelsUtilities.Exceptions.Base;
using System.Net;

namespace Hs_BaseModelsUtilities.Exceptions.GeneralExceptions
{
    /// <summary>
    /// Thrown when user is not authenticated.
    /// </summary>
    public class UnauthorizedException : AppException
    {
        public UnauthorizedException()
            : base("Unauthorized access.", "UNAUTHORIZED", HttpStatusCode.Unauthorized) { }
        public UnauthorizedException(string message) : base(message) { }
        public UnauthorizedException(string message, string errorCode, HttpStatusCode statusCode)
            : base(message, errorCode, statusCode) { }
    }
}
