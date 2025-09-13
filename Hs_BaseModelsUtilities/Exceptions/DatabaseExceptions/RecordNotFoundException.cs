using Hs_BaseModelsUtilities.Exceptions.Base;
using System.Net;

namespace Hs_BaseModelsUtilities.Exceptions.DatabaseExceptions
{
    /// <summary>
    /// Thrown when a record is not found in the database.
    /// </summary>
    public class RecordNotFoundException : AppException
    {
        public RecordNotFoundException()
            : base("Record not found in database.", "RECORD_NOT_FOUND", HttpStatusCode.NotFound) { }
        public RecordNotFoundException(string message) : base(message) { }
        public RecordNotFoundException(string message, string errorCode, HttpStatusCode statusCode)
            : base(message, errorCode, statusCode) { }
    }
}
