
using System.Threading.Tasks;

namespace Hs_BaseModelsUtilities.Interfaces.Security
{
    public interface IRefreshTokenService
    {
        Task<string> GenerateRefreshTokenAsync(string userId);
        Task<bool> ValidateRefreshTokenAsync(string token, string userId);
        Task InvalidateRefreshTokenAsync(string token);
    }


}
