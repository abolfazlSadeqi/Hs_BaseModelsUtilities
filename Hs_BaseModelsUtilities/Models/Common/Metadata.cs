using System;
using System.Collections.Generic;

namespace Hs_BaseModelsUtilities.Models.Common

{


    /// <summary>
    /// Metadata for API responses, observability and tracing
    /// </summary>
    public class Metadata
    {
        public string RequestId { get; set; } = Guid.NewGuid().ToString();
        public string CorrelationId { get; set; } = Guid.NewGuid().ToString();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, object> Metrics { get; set; } = new Dictionary<string, object>();
        public string TraceId { get; set; } = "";
        public string SpanId { get; set; } = "";
    }




}
