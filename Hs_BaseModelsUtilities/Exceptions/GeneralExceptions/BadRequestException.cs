using Hs_BaseModelsUtilities.Exceptions.Base;
using System.Net;

namespace Hs_BaseModelsUtilities.Exceptions.GeneralExceptions
{
    /// <summary>
    /// Thrown when a request is malformed or invalid.
    /// </summary>
    public class BadRequestException : AppException
    {
        public BadRequestException()
            : base("Bad request.", "BAD_REQUEST", HttpStatusCode.BadRequest) { }
        public BadRequestException(string message) : base(message) { }
        public BadRequestException(string message, string errorCode, HttpStatusCode statusCode)
            : base(message, errorCode, statusCode) { }
    }
}
