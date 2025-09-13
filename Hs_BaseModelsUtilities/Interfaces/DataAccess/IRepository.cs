using System.Linq;
using System.Text;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Hs_BaseModelsUtilities.Interfaces.Core;

namespace Hs_BaseModelsUtilities.Interfaces.DataAccess
{


    /// <summary>
    /// Generic repository for CRUD operations
    /// </summary>
    public interface IRepository<T> where T : IEntity
    {
        Task<T> GetByIdAsync(Guid id);
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<bool> ExistsAsync(Guid id);
        Task<int> CountAsync();
    }


}


