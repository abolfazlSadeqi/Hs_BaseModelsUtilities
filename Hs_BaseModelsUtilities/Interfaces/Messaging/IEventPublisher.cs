
using System.Threading.Tasks;

namespace Hs_BaseModelsUtilities.Interfaces.Messaging
{
    public interface IEventPublisher
    {
        Task PublishAsync<TEvent>(TEvent @event);
        Task PublishAsync<TEvent>(TEvent @event, string routingKey);
    }



}
