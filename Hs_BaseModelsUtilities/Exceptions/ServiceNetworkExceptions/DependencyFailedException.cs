using Hs_BaseModelsUtilities.Exceptions.Base;
using System.Net;

namespace Hs_BaseModelsUtilities.Exceptions.ServiceNetworkExceptions
{
    /// <summary>
    /// Thrown when a dependency service fails.
    /// </summary>
    public class DependencyFailedException : AppException
    {
        public DependencyFailedException()
            : base("Dependent service failed.", "DEPENDENCY_FAILED", HttpStatusCode.BadGateway) { }
        public DependencyFailedException(string message) : base(message) { }
        public DependencyFailedException(string message, string errorCode, HttpStatusCode statusCode)
            : base(message, errorCode, statusCode) { }
    }
}
