
using System.Threading.Tasks;

namespace Hs_BaseModelsUtilities.Interfaces.Observability
{
    public interface IHealthCheckService
    {
        Task<bool> CheckHealthAsync(string componentName = null);
    }



}
