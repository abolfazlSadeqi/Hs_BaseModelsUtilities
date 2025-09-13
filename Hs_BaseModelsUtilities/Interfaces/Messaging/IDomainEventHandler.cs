
using System.Threading.Tasks;

namespace Hs_BaseModelsUtilities.Interfaces.Messaging
{
    public interface IDomainEventHandler<TEvent>
    {
        Task HandleAsync(TEvent @event);
    }



}
