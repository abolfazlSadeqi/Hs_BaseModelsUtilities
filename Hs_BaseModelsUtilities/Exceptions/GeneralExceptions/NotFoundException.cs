using Hs_BaseModelsUtilities.Exceptions.Base;
using System.Net;

namespace Hs_BaseModelsUtilities.Exceptions.GeneralExceptions
{

    /// <summary>
    /// Thrown when a requested resource is not found.
    /// </summary>
    public class NotFoundException : AppException
    {
        public NotFoundException()
            : base("Resource not found.", "NOT_FOUND", HttpStatusCode.NotFound) { }
        public NotFoundException(string message) : base(message) { }
        public NotFoundException(string message, string errorCode, HttpStatusCode statusCode)
            : base(message, errorCode, statusCode) { }
    }
}
