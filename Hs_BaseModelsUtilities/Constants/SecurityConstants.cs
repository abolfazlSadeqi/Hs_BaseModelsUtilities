namespace Hs_BaseModelsUtilities.Constants
{
  
    public static class SecurityConstants
    {
        public const string JwtSecretKey = "YourVerySecureSecretKeyHere";
        public const int JwtExpiryMinutes = 60;
        public const string RefreshTokenPrefix = "RefreshToken_";
        public const string DefaultHashAlgorithm = "SHA256";
        public const string OAuthScopeRead = "read";
        public const string OAuthScopeWrite = "write";
        public const string OAuthScopeAdmin = "admin";
        public const string OAuthScopeOfflineAccess = "offline_access";
        public const int PasswordMinLength = 8;
        public const int PasswordMaxLength = 32;
        public const bool PasswordRequireUpper = true;
        public const bool PasswordRequireLower = true;
        public const bool PasswordRequireDigit = true;
        public const bool PasswordRequireSpecial = true;
    }


}
