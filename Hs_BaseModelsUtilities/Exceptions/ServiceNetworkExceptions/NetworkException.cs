using Hs_BaseModelsUtilities.Exceptions.Base;
using System.Net;

namespace Hs_BaseModelsUtilities.Exceptions.ServiceNetworkExceptions
{
    /// <summary>
    /// Thrown when a network error occurs.
    /// </summary>
    public class NetworkException : AppException
    {
        public NetworkException()
            : base("Network error occurred.", "NETWORK_ERROR", HttpStatusCode.ServiceUnavailable) { }
        public NetworkException(string message) : base(message) { }
        public NetworkException(string message, string errorCode, HttpStatusCode statusCode)
            : base(message, errorCode, statusCode) { }
    }
}
