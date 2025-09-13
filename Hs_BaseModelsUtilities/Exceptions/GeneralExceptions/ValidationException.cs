using Hs_BaseModelsUtilities.Exceptions.Base;
using System.Net;

namespace Hs_BaseModelsUtilities.Exceptions.GeneralExceptions
{
    /// <summary>
    /// Thrown when validation fails for request parameters.
    /// </summary>
    public class ValidationException : AppException
    {
        public ValidationException()
            : base("Validation failed.", "VALIDATION_FAILED", HttpStatusCode.BadRequest) { }
        public ValidationException(string message) : base(message) { }
        public ValidationException(string message, string errorCode, HttpStatusCode statusCode)
            : base(message, errorCode, statusCode) { }
    }
}
