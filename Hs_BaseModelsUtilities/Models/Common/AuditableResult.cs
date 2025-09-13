namespace Hs_BaseModelsUtilities.Models.Common

{

    /// <summary>
    /// Represents a result with auditing info
    /// </summary>
    public class AuditableResult<T> : DataResult<T>
    {
        public AuditInfo Audit { get; set; }

        public AuditableResult(T data, AuditInfo audit, bool success = true, string message = "Operation completed successfully.")
            : base(data, success, message)
        {
            Audit = audit;
        }
    }




}
