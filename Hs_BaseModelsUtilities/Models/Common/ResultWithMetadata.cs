namespace Hs_BaseModelsUtilities.Models.Common

{

    /// <summary>
    /// Represents a result with additional metadata
    /// </summary>
    public class ResultWithMetadata<T> : DataResult<T>
    {
        public Metadata Metadata { get; set; }

        public ResultWithMetadata(T data, Metadata metadata, bool success = true, string message = "Operation completed successfully.")
            : base(data, success, message)
        {
            Metadata = metadata;
        }
    }




}
