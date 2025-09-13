using System;

namespace Hs_BaseModelsUtilities.Models.Common

{

    /// <summary>
    /// Auditing information for entities
    /// </summary>
    public class AuditInfo
    {
        public string CreatedBy { get; set; } = "";
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string UpdatedBy { get; set; } = "";
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }




}
