using System.Collections.Generic;

namespace Hs_BaseModelsUtilities.Models.Common

{
   
    /// <summary>
    /// Generic service response wrapper
    /// </summary>
    public class ServiceResponse<T>
    {
        public bool Success { get; set; } = true;
        public string Message { get; set; } = "Operation completed successfully.";
        public T Data { get; set; }
        public List<ValidationError> Errors { get; set; } = new List<ValidationError>();
        public Metadata Metadata { get; set; } = new Metadata();
    }




}
