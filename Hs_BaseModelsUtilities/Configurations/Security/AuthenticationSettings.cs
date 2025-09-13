namespace Hs_BaseModelsUtilities.Configurations.Security
{
    /// <summary>
    /// Authentication configuration (local and OAuth2)
    /// </summary>
    public class AuthenticationSettings
    {
        public bool EnableLocalAuth { get; set; } = true; // Enable local authentication
        public bool EnableOAuth2 { get; set; } = true; // Enable OAuth2 authentication
        public string Authority { get; set; } = "https://identity.myapp.com"; // OAuth2 authority URL
        public string ClientId { get; set; } = "client-id"; // OAuth2 client ID
        public string ClientSecret { get; set; } = "secret"; // OAuth2 client secret
        public string[] Scopes { get; set; } = new string[] { "openid", "profile", "api" }; // OAuth2 scopes
    }
}



