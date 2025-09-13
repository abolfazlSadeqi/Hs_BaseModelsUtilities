namespace Hs_BaseModelsUtilities.Configurations.Security
{
    /// <summary>
    /// JWT authentication and token management settings
    /// </summary>
    public class JwtSettings
    {
        public string PrimarySecretKey { get; set; } = "PrimaryVerySecureKey"; // Main signing key
        public string SecondarySecretKey { get; set; } = "SecondarySecureKeyForRotation"; // Key for rotation
        public string Issuer { get; set; } = "MyAppIssuer"; // Token issuer
        public string Audience { get; set; } = "MyAppAudience"; // Token audience
        public int ExpiryMinutes { get; set; } = 60; // Access token expiration
        public int RefreshTokenExpiryDays { get; set; } = 30; // Refresh token expiration
        public string Algorithm { get; set; } = "HS256"; // Signing algorithm
        public bool EnableKeyRotation { get; set; } = true; // Key rotation enabled


    }
}



