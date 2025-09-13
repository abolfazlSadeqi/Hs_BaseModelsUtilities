
using Hs_BaseModelsUtilities.Interfaces.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hs_BaseModelsUtilities.Interfaces.DataAccess
{
    public interface IEventSourcingRepository<T> where T : IAggregateRoot
    {
        Task SaveEventsAsync(T aggregate);
        Task<IEnumerable<object>> GetEventsAsync(Guid aggregateId);
        Task<IEnumerable<object>> GetEventsByTypeAsync(string eventType);
    }

}


