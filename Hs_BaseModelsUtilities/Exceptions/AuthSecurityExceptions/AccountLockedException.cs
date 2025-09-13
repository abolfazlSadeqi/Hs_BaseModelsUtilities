using Hs_BaseModelsUtilities.Exceptions.Base;
using System.Net;

namespace Hs_BaseModelsUtilities.Exceptions.AuthSecurityExceptions
{
    /// <summary>
    /// Thrown when an account is locked.
    /// </summary>
    public class AccountLockedException : AppException
    {
        public AccountLockedException()
            : base("Account is locked.", "ACCOUNT_LOCKED", HttpStatusCode.Forbidden) { }
        public AccountLockedException(string message) : base(message) { }
        public AccountLockedException(string message, string errorCode, HttpStatusCode statusCode)
            : base(message, errorCode, statusCode) { }
    }
}
