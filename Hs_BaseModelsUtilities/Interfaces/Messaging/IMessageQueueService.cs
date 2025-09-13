
using System;
using System.Threading.Tasks;

namespace Hs_BaseModelsUtilities.Interfaces.Messaging
{
    public interface IMessageQueueService
    {
        Task SendMessageAsync(string queueName, object message);
        Task ReceiveMessagesAsync(string queueName, Func<object, Task> handler);
        Task<int> GetQueueLengthAsync(string queueName);
    }



}
