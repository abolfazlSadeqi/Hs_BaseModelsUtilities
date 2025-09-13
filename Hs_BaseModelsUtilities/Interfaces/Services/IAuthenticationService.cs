
using Hs_BaseModelsUtilities.Interfaces.Core;
using System.Threading.Tasks;

namespace Hs_BaseModelsUtilities.Interfaces.Services
{
    public interface IAuthenticationService : IApplicationService
    {
        Task<string> LoginAsync(string username, string password);
        Task LogoutAsync(string token);
        Task<bool> ValidateTokenAsync(string token);
    }



}
