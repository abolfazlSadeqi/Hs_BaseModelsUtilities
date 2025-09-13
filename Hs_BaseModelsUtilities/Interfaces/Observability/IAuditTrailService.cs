
using System.Threading.Tasks;

namespace Hs_BaseModelsUtilities.Interfaces.Observability
{
    public interface IAuditTrailService
    {
        Task RecordAsync(string userId, string action, string entityName, string entityId, string description = null);
    }




}
