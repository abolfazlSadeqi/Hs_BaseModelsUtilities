namespace Hs_BaseModelsUtilities.Models.Common

{

    /// <summary>
    /// Query request with filtering, sorting, and pagination
    /// </summary>
    public class QueryRequest
    {
        public Filter Filter { get; set; } = new Filter();
        public Sorting Sorting { get; set; } = new Sorting();
        public Pagination Pagination { get; set; } = new Pagination();
    }




}
