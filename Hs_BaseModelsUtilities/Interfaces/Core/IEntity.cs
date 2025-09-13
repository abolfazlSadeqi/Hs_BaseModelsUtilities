
using System;

namespace Hs_BaseModelsUtilities.Interfaces.Core
{
    /// <summary>
    /// Base interface for all entities with auditing properties
    /// </summary>
    public interface IEntity
    {
        Guid Id { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
        string CreatedBy { get; set; }
        string UpdatedBy { get; set; }
    }


}
