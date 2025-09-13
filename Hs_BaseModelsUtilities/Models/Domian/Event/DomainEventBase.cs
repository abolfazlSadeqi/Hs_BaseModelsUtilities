using Hs_BaseModelsUtilities.Models.Domian.Interface;
using System;

namespace Hs_BaseModelsUtilities.Models.Domian.Event
{
    /// <summary>
    /// Base class for domain events
    /// </summary>
    public abstract class DomainEventBase : IDomainEvent
    {
        public DateTime OccurredOn { get; protected set; } = DateTime.UtcNow;
    }




}
