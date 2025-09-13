namespace Hs_BaseModelsUtilities.Models.Common
{
    /// <summary>
    /// Base operation result
    /// </summary>
    public class Result
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public Result(bool success, string message)
        {
            Success = success;
            Message = message;
        }
    }

}
