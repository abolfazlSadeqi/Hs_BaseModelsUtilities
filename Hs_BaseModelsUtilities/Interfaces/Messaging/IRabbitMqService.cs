
using System.Threading.Tasks;

namespace Hs_BaseModelsUtilities.Interfaces.Messaging
{
    public interface IRabbitMqService : IMessageQueueService
    {
        Task DeclareExchangeAsync(string exchangeName);
        Task DeclareQueueAsync(string queueName);
        Task BindQueueAsync(string queueName, string exchangeName, string routingKey);
    }



}
