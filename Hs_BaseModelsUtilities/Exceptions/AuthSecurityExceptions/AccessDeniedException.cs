using Hs_BaseModelsUtilities.Exceptions.Base;
using System.Net;

namespace Hs_BaseModelsUtilities.Exceptions.AuthSecurityExceptions
{
    /// <summary>
    /// Thrown when access is denied due to permissions.
    /// </summary>
    public class AccessDeniedException : AppException
    {
        public AccessDeniedException()
            : base("Access denied.", "ACCESS_DENIED", HttpStatusCode.Forbidden) { }
        public AccessDeniedException(string message) : base(message) { }
        public AccessDeniedException(string message, string errorCode, HttpStatusCode statusCode)
            : base(message, errorCode, statusCode) { }
    }
}
