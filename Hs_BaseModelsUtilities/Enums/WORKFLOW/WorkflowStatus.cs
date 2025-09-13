namespace Hs_BaseModelsUtilities.Enums.WORKFLOW
{
   
    /// <summary>
    /// Workflow status for business processes.
    /// </summary>
    public enum WorkflowStatus
        {
            Draft = 1,
            PendingApproval = 2,
            Approved = 3,
            Rejected = 4,
            Completed = 5,
            Cancelled = 6
        }
    }
