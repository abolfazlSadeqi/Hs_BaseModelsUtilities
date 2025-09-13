
using System;
using System.Threading.Tasks;

namespace Hs_BaseModelsUtilities.Interfaces.Scheduling
{
    public interface IJobQueueService
    {
        Task EnqueueAsync(string queueName, Func<Task> job);
        Task<int> GetQueueLengthAsync(string queueName);
        Task ClearQueueAsync(string queueName);
    }



}
