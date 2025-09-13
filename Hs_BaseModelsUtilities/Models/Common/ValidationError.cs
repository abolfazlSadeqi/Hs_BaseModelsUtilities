namespace Hs_BaseModelsUtilities.Models.Common

{

    /// <summary>
    /// Represents a single validation error
    /// </summary>
    public class ValidationError
    {
        public string Field { get; set; } = "";
        public string Message { get; set; } = "";
        public string Code { get; set; } = "VALIDATION_ERROR";
    }




}
