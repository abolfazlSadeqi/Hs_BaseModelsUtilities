using Hs_BaseModelsUtilities.Models.Domian.Base;

namespace Hs_BaseModelsUtilities.Models.Domian.Event
{
    /// <summary>
    /// Entity created event
    /// </summary>
    public class CreatedEvent<TEntity> : DomainEventBase where TEntity : BaseEntity
    {
        public TEntity Entity { get; }

        public CreatedEvent(TEntity entity)
        {
            Entity = entity;
        }
    }




}
