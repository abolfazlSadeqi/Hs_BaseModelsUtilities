
using Hs_BaseModelsUtilities.Interfaces.Core;
using System;
using System.Threading.Tasks;

namespace Hs_BaseModelsUtilities.Interfaces.Services
{
    public interface IUserDomainService : IDomainService
    {
        Task<bool> IsUserActiveAsync(Guid userId);
        Task<bool> ValidateUserRoleAsync(Guid userId, string role);
    }



}
