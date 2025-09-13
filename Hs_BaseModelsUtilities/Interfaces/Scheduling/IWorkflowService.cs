
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hs_BaseModelsUtilities.Interfaces.Scheduling
{
    public interface IWorkflowService
    {
        Task RunWorkflowAsync(string workflowName, IDictionary<string, object> context);
        Task CancelWorkflowAsync(string workflowName);
        Task<bool> IsWorkflowRunningAsync(string workflowName);
    }



}
