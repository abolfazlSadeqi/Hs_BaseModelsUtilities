using Hs_BaseModelsUtilities.Exceptions.Base;
using System.Net;

namespace Hs_BaseModelsUtilities.Exceptions.FileStorageExceptions
{

    /// <summary>
    /// Thrown when a file operation fails.
    /// </summary>
    public class FileOperationException : AppException
    {
        public FileOperationException()
            : base("File operation failed.", "FILE_OPERATION_FAILED", HttpStatusCode.InternalServerError) { }
        public FileOperationException(string message) : base(message) { }
        public FileOperationException(string message, string errorCode, HttpStatusCode statusCode)
            : base(message, errorCode, statusCode) { }
    }
}
