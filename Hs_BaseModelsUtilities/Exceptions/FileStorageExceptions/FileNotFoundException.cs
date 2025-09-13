using Hs_BaseModelsUtilities.Exceptions.Base;
using System.Net;

namespace Hs_BaseModelsUtilities.Exceptions.FileStorageExceptions
{
    /// <summary>
    /// Thrown when a file is not found.
    /// </summary>
    public class FileNotFoundException : AppException
    {
        public FileNotFoundException()
            : base("File not found.", "FILE_NOT_FOUND", HttpStatusCode.NotFound) { }
        public FileNotFoundException(string message) : base(message) { }
        public FileNotFoundException(string message, string errorCode, HttpStatusCode statusCode)
            : base(message, errorCode, statusCode) { }
    }
}
