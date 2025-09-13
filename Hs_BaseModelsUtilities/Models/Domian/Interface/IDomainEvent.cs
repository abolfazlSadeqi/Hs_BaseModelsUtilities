using System;

namespace Hs_BaseModelsUtilities.Models.Domian.Interface
{
    /// <summary>
    /// Base interface for domain events
    /// </summary>
    public interface IDomainEvent
    {
        DateTime OccurredOn { get; }
    }




}
