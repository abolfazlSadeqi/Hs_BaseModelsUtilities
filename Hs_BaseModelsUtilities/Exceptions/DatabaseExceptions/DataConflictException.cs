using Hs_BaseModelsUtilities.Exceptions.Base;
using System.Net;

namespace Hs_BaseModelsUtilities.Exceptions.DatabaseExceptions
{
    /// <summary>
    /// Thrown when data conflicts in the database.
    /// </summary>
    public class DataConflictException : AppException
    {
        public DataConflictException()
            : base("Data conflict occurred.", "DATA_CONFLICT", HttpStatusCode.Conflict) { }
        public DataConflictException(string message) : base(message) { }
        public DataConflictException(string message, string errorCode, HttpStatusCode statusCode)
            : base(message, errorCode, statusCode) { }
    }
}
