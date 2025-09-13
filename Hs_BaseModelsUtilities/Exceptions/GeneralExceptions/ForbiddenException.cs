using Hs_BaseModelsUtilities.Exceptions.Base;
using System.Net;

namespace Hs_BaseModelsUtilities.Exceptions.GeneralExceptions
{
    /// <summary>
    /// Thrown when user is forbidden to access a resource.
    /// </summary>
    public class ForbiddenException : AppException
    {
        public ForbiddenException()
            : base("Access forbidden.", "FORBIDDEN", HttpStatusCode.Forbidden) { }
        public ForbiddenException(string message) : base(message) { }
        public ForbiddenException(string message, string errorCode, HttpStatusCode statusCode)
            : base(message, errorCode, statusCode) { }
    }
}
