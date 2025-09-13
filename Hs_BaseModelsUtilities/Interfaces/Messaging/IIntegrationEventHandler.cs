using System.Threading.Tasks;

namespace Hs_BaseModelsUtilities.Interfaces.Messaging
{
    public interface IIntegrationEventHandler<TEvent>
    {
        Task HandleAsync(TEvent @event);
    }


}
