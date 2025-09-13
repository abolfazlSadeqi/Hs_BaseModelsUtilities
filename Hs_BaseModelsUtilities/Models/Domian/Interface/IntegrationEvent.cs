using System;

namespace Hs_BaseModelsUtilities.Models.Domian.Interface
{
    /// <summary>
    /// Base class for integration events
    /// </summary>
    public abstract class IntegrationEvent
    {
        public Guid EventId { get; } = Guid.NewGuid();
        public DateTime CreatedAt { get; } = DateTime.UtcNow;
    }




}
