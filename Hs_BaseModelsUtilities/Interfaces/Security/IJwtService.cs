
using System.Collections.Generic;

namespace Hs_BaseModelsUtilities.Interfaces.Security
{
    public interface IJwtService
    {
        string GenerateToken(string userId, IDictionary<string, string> claims = null, int expiryMinutes = 60);
        bool ValidateToken(string token, out IDictionary<string, string> claims);
        string RefreshToken(string refreshToken);
    }



}
