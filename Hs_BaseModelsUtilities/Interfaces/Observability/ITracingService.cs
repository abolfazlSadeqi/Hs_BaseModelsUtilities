
using System;
using System.Collections.Generic;

namespace Hs_BaseModelsUtilities.Interfaces.Observability
{
    public interface ITracingService
    {
        IDisposable StartSpan(string operationName, IDictionary<string, string> tags = null);
    }



}
