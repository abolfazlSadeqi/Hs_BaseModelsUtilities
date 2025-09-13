using Hs_BaseModelsUtilities.Exceptions.Base;
using System.Net;

namespace Hs_BaseModelsUtilities.Exceptions.DatabaseExceptions
{

    /// <summary>
    /// Thrown when database service is unavailable.
    /// </summary>
    public class DatabaseUnavailableException : AppException
    {
        public DatabaseUnavailableException()
            : base("Database is unavailable.", "DATABASE_UNAVAILABLE", HttpStatusCode.ServiceUnavailable) { }
        public DatabaseUnavailableException(string message) : base(message) { }
        public DatabaseUnavailableException(string message, string errorCode, HttpStatusCode statusCode)
            : base(message, errorCode, statusCode) { }
    }
}
