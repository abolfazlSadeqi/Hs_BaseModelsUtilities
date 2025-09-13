namespace Hs_BaseModelsUtilities.Models.Common

{
    /// <summary>
    /// Represents a paginated result set
    /// </summary>
    public class PaginatedResult<T> : DataResult<T>
    {
        public Pagination Pagination { get; set; }

        public PaginatedResult(T data, Pagination pagination, bool success = true, string message = "Operation completed successfully.")
            : base(data, success, message)
        {
            Pagination = pagination;
        }
    }




}
