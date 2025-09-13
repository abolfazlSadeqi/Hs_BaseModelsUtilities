
using Hs_BaseModelsUtilities.Interfaces.Core;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hs_BaseModelsUtilities.Interfaces.Services
{
    public interface IExternalApiService : IApplicationService
    {
        Task<string> GetAsync(string url, IDictionary<string, string> headers = null);
        Task<string> PostAsync(string url, object body, IDictionary<string, string> headers = null);
    }



}
