
using System;
using System.Threading.Tasks;

namespace Hs_BaseModelsUtilities.Interfaces.Scheduling
{
    public interface IRetryPolicyService
    {
        Task ExecuteWithRetryAsync(Func<Task> action, int maxRetryCount = 3, TimeSpan? delay = null);
    }



}
