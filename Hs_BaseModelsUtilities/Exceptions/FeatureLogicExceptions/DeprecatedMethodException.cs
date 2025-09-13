using Hs_BaseModelsUtilities.Exceptions.Base;
using System.Net;

namespace Hs_BaseModelsUtilities.Exceptions.FeatureLogicExceptions
{
    /// <summary>
    /// Thrown when a deprecated method is called.
    /// </summary>
    public class DeprecatedMethodException : AppException
    {
        public DeprecatedMethodException()
            : base("Method is deprecated.", "DEPRECATED_METHOD", HttpStatusCode.BadRequest) { }
        public DeprecatedMethodException(string message) : base(message) { }
        public DeprecatedMethodException(string message, string errorCode, HttpStatusCode statusCode)
            : base(message, errorCode, statusCode) { }
    }
}
