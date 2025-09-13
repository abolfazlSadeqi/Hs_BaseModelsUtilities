using Hs_BaseModelsUtilities.Exceptions.Base;
using System.Net;

namespace Hs_BaseModelsUtilities.Exceptions.GeneralExceptions
{
    /// <summary>
    /// Thrown when a conflict occurs, such as duplicate resource creation.
    /// </summary>
    public class ConflictException : AppException
    {
        public ConflictException()
            : base("Conflict occurred.", "CONFLICT", HttpStatusCode.Conflict) { }
        public ConflictException(string message) : base(message) { }
        public ConflictException(string message, string errorCode, HttpStatusCode statusCode)
            : base(message, errorCode, statusCode) { }
    }
}
