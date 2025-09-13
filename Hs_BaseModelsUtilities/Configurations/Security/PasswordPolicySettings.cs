namespace Hs_BaseModelsUtilities.Configurations.Security
{
    /// <summary>
    /// Password complexity and lockout policy
    /// </summary>
    public class PasswordPolicySettings
    {
        public int MinLength { get; set; } = 8; // Minimum password length
        public bool RequireUppercase { get; set; } = true; // Require uppercase letter
        public bool RequireLowercase { get; set; } = true; // Require lowercase letter
        public bool RequireDigit { get; set; } = true; // Require numeric digit
        public bool RequireSpecialCharacter { get; set; } = true; // Require special character
        public int MaxFailedAttempts { get; set; } = 5; // Maximum failed login attempts
        public int LockoutMinutes { get; set; } = 15; // Lockout duration in minutes
    }
}



