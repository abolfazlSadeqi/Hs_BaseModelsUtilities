namespace Hs_BaseModelsUtilities.Enums.INFRASTRUCTURE
{
    /// <summary>
    /// Transaction isolation levels.
    /// </summary>
    public enum TransactionIsolationLevel
        {
            ReadUncommitted = 1,
            ReadCommitted = 2,
            RepeatableRead = 3,
            Serializable = 4,
            Snapshot = 5
        }
    }
