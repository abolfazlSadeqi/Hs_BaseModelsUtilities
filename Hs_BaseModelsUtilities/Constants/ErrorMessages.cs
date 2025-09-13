using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hs_BaseModelsUtilities.Constants
{
    public static class ErrorMessages
    {



        public const string InvalidEmail = "The email address is not valid.";
        public const string InvalidPhone = "The phone number is not valid.";
        public const string PasswordTooWeak = "The password does not meet complexity requirements.";
        public const string NotFound = "The requested resource was not found.";
        public const string Unauthorized = "You are not authorized to perform this action.";
        public const string Forbidden = "Access to this resource is forbidden.";
        public const string Conflict = "The resource already exists.";
        public const string InternalServerError = "An internal server error has occurred.";
        public const string OperationSuccessful = "The operation completed successfully.";
        public const string OperationFailed = "The operation failed.";
        public const string OperationPending = "The operation is pending.";
        public const string TimeoutOccurred = "The operation timed out.";
        public const string DatabaseUnavailable = "Database is currently unavailable.";
        public const string ServiceUnavailable = "Service is currently unavailable.";
        public const string InvalidState = "The object is in an invalid state.";
        public const string AlreadyProcessed = "The item has already been processed.";
        public const string FeatureNotImplemented = "This feature is not implemented yet.";
        public const string DeprecatedMethod = "This method is deprecated.";
        public const string FieldMismatch = "Field values do not match.";
        public const string DependencyFailed = "A dependent operation failed.";
        public const string RateLimitExceeded = "Rate limit has been exceeded.";

        public const string RequiredField = "This field is required.";

    }


}
