using Hs_BaseModelsUtilities.Exceptions.Base;
using System.Net;

namespace Hs_BaseModelsUtilities.Exceptions.FeatureLogicExceptions
{

    /// <summary>
    /// Thrown when a feature is not implemented.
    /// </summary>
    public class NotImplementedFeatureException : AppException
    {
        public NotImplementedFeatureException()
            : base("Feature not implemented.", "NOT_IMPLEMENTED", HttpStatusCode.NotImplemented) { }
        public NotImplementedFeatureException(string message) : base(message) { }
        public NotImplementedFeatureException(string message, string errorCode, HttpStatusCode statusCode)
            : base(message, errorCode, statusCode) { }
    }
}
