using Hs_BaseModelsUtilities.Models.Domian.Base;

namespace Hs_BaseModelsUtilities.Models.Domian.Event
{
    /// <summary>
    /// Entity updated event
    /// </summary>
    public class UpdatedEvent<TEntity> : DomainEventBase where TEntity : BaseEntity
    {
        public TEntity Entity { get; }

        public UpdatedEvent(TEntity entity)
        {
            Entity = entity;
        }



    }

}
