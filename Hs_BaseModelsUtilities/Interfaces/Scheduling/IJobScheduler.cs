
using System;
using System.Threading.Tasks;

namespace Hs_BaseModelsUtilities.Interfaces.Scheduling
{
    public interface IJobScheduler
    {
        Task ScheduleJobAsync(string jobName, DateTime executeAt, Func<Task> jobAction, string queueName = "default");
        Task CancelJobAsync(string jobName);
        Task<bool> IsJobScheduledAsync(string jobName);
    }



}
