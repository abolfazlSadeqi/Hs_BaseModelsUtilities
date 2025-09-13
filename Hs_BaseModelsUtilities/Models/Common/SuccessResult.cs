namespace Hs_BaseModelsUtilities.Models.Common

{

    /// <summary>
    /// Represents a successful result
    /// </summary>
    public class SuccessResult : Result
    {
        public SuccessResult(string message = "Operation completed successfully.")
            : base(true, message) { }
    }




}
