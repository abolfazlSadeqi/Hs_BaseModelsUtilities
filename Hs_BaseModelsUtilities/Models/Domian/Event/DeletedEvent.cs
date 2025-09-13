using Hs_BaseModelsUtilities.Models.Domian.Base;

namespace Hs_BaseModelsUtilities.Models.Domian.Event
{
    /// <summary>
    /// Entity deleted event
    /// </summary>
    public class DeletedEvent<TEntity> : DomainEventBase where TEntity : BaseEntity
    {
        public TEntity Entity { get; }

        public DeletedEvent(TEntity entity)
        {
            Entity = entity;
        }



    }

}
