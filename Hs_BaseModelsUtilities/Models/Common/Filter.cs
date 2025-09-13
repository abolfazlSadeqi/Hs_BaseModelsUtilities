using System.Collections.Generic;

namespace Hs_BaseModelsUtilities.Models.Common

{
    
    /// <summary>
    /// Filtering parameters for queries
    /// </summary>
    public class Filter
    {
        public Dictionary<string, object> Conditions { get; set; } = new Dictionary<string, object>();
    }




}
