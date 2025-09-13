using Hs_BaseModelsUtilities.Exceptions.Base;
using System.Net;

namespace Hs_BaseModelsUtilities.Exceptions.ServiceNetworkExceptions
{

    /// <summary>
    /// Thrown when a service is unavailable.
    /// </summary>
    public class ServiceUnavailableException : AppException
    {
        public ServiceUnavailableException()
            : base("Service is currently unavailable.", "SERVICE_UNAVAILABLE", HttpStatusCode.ServiceUnavailable) { }
        public ServiceUnavailableException(string message) : base(message) { }
        public ServiceUnavailableException(string message, string errorCode, HttpStatusCode statusCode)
            : base(message, errorCode, statusCode) { }
    }
}
