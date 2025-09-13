using Hs_BaseModelsUtilities.Exceptions.Base;
using System.Net;

namespace Hs_BaseModelsUtilities.Exceptions.FileStorageExceptions
{
    /// <summary>
    /// Thrown when file access is denied.
    /// </summary>
    public class FileAccessDeniedException : AppException
    {
        public FileAccessDeniedException()
            : base("Access to file denied.", "FILE_ACCESS_DENIED", HttpStatusCode.Forbidden) { }
        public FileAccessDeniedException(string message) : base(message) { }
        public FileAccessDeniedException(string message, string errorCode, HttpStatusCode statusCode)
            : base(message, errorCode, statusCode) { }
    }
}
