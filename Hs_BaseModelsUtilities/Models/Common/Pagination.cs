using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hs_BaseModelsUtilities.Models.Common

{

    /// <summary>
    /// Pagination parameters for queries
    /// </summary>
    public class Pagination
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public int TotalItems { get; set; }
        public int TotalPages => (int)Math.Ceiling((double)TotalItems / PageSize);
    }



}
