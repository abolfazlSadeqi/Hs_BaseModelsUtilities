
using System.Threading.Tasks;

namespace Hs_BaseModelsUtilities.Interfaces.Security
{
    public interface IOAuthService
    {
        Task<string> GetAccessTokenAsync(string clientId, string clientSecret, string scope);
        Task<bool> ValidateAccessTokenAsync(string token);
    }



}
