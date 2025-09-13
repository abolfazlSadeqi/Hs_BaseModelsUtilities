using Hs_BaseModelsUtilities.Models.Domian.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hs_BaseModelsUtilities.Models.Domian.Base
{


    /// <summary>
    /// Base class for all entities with Id and auditing info
    /// </summary>
    public abstract class BaseEntity
    {
        public DateTime CreatedAt { get; protected set; } = DateTime.UtcNow;
        public string CreatedBy { get; protected set; } = "system";
        public DateTime UpdatedAt { get; protected set; } = DateTime.UtcNow;
        public string UpdatedBy { get; protected set; } = "system";
        public int Version { get; protected set; } = 1;

        private readonly List<IDomainEvent> _domainEvents = new();
        public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

        protected void AddDomainEvent(IDomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }

        protected void RemoveDomainEvent(IDomainEvent domainEvent)
        {
            _domainEvents.Remove(domainEvent);
        }

        protected void ClearDomainEvents()
        {
            _domainEvents.Clear();
        }
    }



}
