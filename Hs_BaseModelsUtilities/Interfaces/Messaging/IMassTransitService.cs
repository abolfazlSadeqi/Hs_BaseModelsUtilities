
using System.Threading.Tasks;

namespace Hs_BaseModelsUtilities.Interfaces.Messaging
{
    public interface IMassTransitService : IMessageQueueService
    {
        Task ConfigureBusAsync(string host, string username, string password);
        Task StartBusAsync();
        Task StopBusAsync();
    }



}
