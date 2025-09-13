
using Hs_BaseModelsUtilities.Interfaces.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hs_BaseModelsUtilities.Interfaces.DataAccess
{
    /// <summary>
    /// Read-only repository
    /// </summary>
    public interface IReadRepository<T> where T : IEntity
    {
        Task<T> GetByIdAsync(Guid id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> FindAsync(Func<T, bool> predicate);
        Task<int> CountAsync();
    }


}


