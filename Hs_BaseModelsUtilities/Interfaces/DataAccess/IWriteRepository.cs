using Hs_BaseModelsUtilities.Interfaces.Core;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Hs_BaseModelsUtilities.Interfaces.DataAccess
{
    


    /// <summary>
    /// Write-only repository
    /// </summary>
    public interface IWriteRepository<T> where T : IEntity
    {
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        Task DeleteRangeAsync(IEnumerable<T> entities);
    }




}
