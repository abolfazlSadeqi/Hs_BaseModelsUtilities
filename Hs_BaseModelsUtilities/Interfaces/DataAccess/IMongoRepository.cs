
using Hs_BaseModelsUtilities.Interfaces.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hs_BaseModelsUtilities.Interfaces.DataAccess
{
    public interface IMongoRepository<T> : IRepository<T> where T : IEntity
    {
        Task<IEnumerable<T>> FindAsync(Func<T, bool> filter);
    }



}
