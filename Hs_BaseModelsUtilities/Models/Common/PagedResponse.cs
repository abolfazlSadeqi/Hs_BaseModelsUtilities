namespace Hs_BaseModelsUtilities.Models.Common

{
   
    /// <summary>
    /// Generic API response for multiple items with pagination
    /// </summary>
    public class PagedResponse<T>
    {
        public List<T> Items { get; set; } = new List<T>();
        public Pagination Pagination { get; set; } = new Pagination();
        public Metadata Metadata { get; set; } = new Metadata();
        public bool Success { get; set; } = true;
        public string Message { get; set; } = "Operation completed successfully.";
        public List<ValidationError> Errors { get; set; } = new List<ValidationError>();


    }

}
