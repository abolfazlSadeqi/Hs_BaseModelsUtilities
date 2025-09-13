
using Hs_BaseModelsUtilities.Interfaces.Core;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hs_BaseModelsUtilities.Interfaces.Services
{
    public interface INotificationService : IApplicationService
    {
        Task SendNotificationAsync(string userId, string message, string type = "General");
        Task BroadcastNotificationAsync(IEnumerable<string> userIds, string message);
    }



}
