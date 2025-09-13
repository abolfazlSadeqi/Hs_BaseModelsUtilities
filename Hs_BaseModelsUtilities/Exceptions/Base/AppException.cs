using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Hs_BaseModelsUtilities.Exceptions.Base
{
    /// <summary>
    /// Base application exception class with ErrorCode and HttpStatusCode.
    /// </summary>
    public class AppException : Exception
    {
        public string ErrorCode { get; }
        public HttpStatusCode StatusCode { get; }

        public AppException()
            : base("An unexpected application error occurred.")
        {
            ErrorCode = "UNKNOWN";
            StatusCode = HttpStatusCode.InternalServerError;
        }

        public AppException(string message)
            : base(message) { }

        public AppException(string message, string errorCode, HttpStatusCode statusCode)
            : base(message)
        {
            ErrorCode = errorCode;
            StatusCode = statusCode;
        }
    }
}
