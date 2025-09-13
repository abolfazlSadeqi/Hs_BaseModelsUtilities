
using Hs_BaseModelsUtilities.Interfaces.Core;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hs_BaseModelsUtilities.Interfaces.Services
{
    public interface IEmailService : IApplicationService
    {
        Task SendEmailAsync(string to, string subject, string body, bool isHtml = true);
        Task SendBulkEmailAsync(IEnumerable<string> to, string subject, string body);
        Task<bool> ValidateEmailAsync(string email);
    }



}
