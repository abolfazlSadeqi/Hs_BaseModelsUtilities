
using Hs_BaseModelsUtilities.Interfaces.Core;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hs_BaseModelsUtilities.Interfaces.Services
{
    public interface ISmsService : IApplicationService
    {
        Task SendSmsAsync(string phoneNumber, string message);
        Task SendBulkSmsAsync(IEnumerable<string> phoneNumbers, string message);
    }



}
