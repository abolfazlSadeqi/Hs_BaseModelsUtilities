
using Hs_BaseModelsUtilities.Interfaces.Core;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hs_BaseModelsUtilities.Interfaces.Services
{
    public interface IAuthorizationService : IApplicationService
    {
        Task<bool> HasAccessAsync(string userId, string permission);
        Task<IEnumerable<string>> GetUserPermissionsAsync(string userId);
    }



}
