using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hs_BaseModelsUtilities.Enums.JOBS
{

    /// <summary>
    /// Background job status.
    /// </summary>
    public enum JobStatus
    {
        Queued = 1,
        Running = 2,
        Completed = 3,
        Failed = 4,
        Cancelled = 5,
        Retried = 6
    }
    

}