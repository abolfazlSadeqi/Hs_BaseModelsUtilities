namespace Hs_BaseModelsUtilities.Models.Common

{
   
        /// <summary>
        /// Generic data result
        /// </summary>
        public class DataResult<T> : Result
        {
            public T Data { get; set; }

            public DataResult(T data, bool success, string message)
                : base(success, message)
            {
                Data = data;
            }
        }

       
    

}
