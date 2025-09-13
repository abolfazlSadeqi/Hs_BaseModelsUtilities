namespace Hs_BaseModelsUtilities.Models.Common

{

    /// <summary>
    /// Multi-tenant context information
    /// </summary>
    public class TenantContext
    {
        public string TenantId { get; set; } = "";
        public string TenantName { get; set; } = "";
        public string Environment { get; set; } = "Development";
    }




}
