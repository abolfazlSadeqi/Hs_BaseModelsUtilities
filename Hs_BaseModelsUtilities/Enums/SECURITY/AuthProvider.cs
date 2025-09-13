namespace Hs_BaseModelsUtilities.Enums.SECURITY
{
 
    /// <summary>
    /// Authentication providers.
    /// </summary>
    public enum AuthProvider
        {
            Jwt = 1,
            OAuth2 = 2,
            OpenIdConnect = 3,
            SAML = 4,
            ApiKey = 5,
            LDAP = 6,
            WindowsAuth = 7
        }
    }
