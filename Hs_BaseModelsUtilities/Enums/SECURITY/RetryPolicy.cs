namespace Hs_BaseModelsUtilities.Enums.SECURITY
{
    /// <summary>
    /// Retry policies.
    /// </summary>
    public enum RetryPolicy
    {
        None = 0,
        Immediate = 1,
        FixedDelay = 2,
        ExponentialBackoff = 3,
        Custom = 99
    }



}