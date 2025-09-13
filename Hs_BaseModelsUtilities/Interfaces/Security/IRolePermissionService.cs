
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hs_BaseModelsUtilities.Interfaces.Security
{
    public interface IRolePermissionService
    {
        Task<bool> HasPermissionAsync(string roleId, string permission);
        Task<IEnumerable<string>> GetRolePermissionsAsync(string roleId);
    }



}
