namespace Hs_BaseModelsUtilities.Models.Common

{

    /// <summary>
    /// Represents a failed result
    /// </summary>
    public class ErrorResult : Result
    {
        public ErrorResult(string message = "An error occurred.")
            : base(false, message) { }
    }




}
