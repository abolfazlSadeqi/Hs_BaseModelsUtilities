
using System;
using System.Threading.Tasks;

namespace Hs_BaseModelsUtilities.Interfaces.DataAccess
{
    public interface IRedisCacheRepository
    {
        Task SetAsync<T>(string key, T value, TimeSpan? expiry = null);
        Task<T> GetAsync<T>(string key);
        Task RemoveAsync(string key);
        Task<bool> ExistsAsync(string key);
        Task ClearAsync();
    }


}
