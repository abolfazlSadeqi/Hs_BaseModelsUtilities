namespace Hs_BaseModelsUtilities.Models.Common

{
    
    /// <summary>
    /// Represents authenticated user information and JWT claims
    /// </summary>
    public class UserContext
    {
        public string UserId { get; set; } = "";
        public string UserName { get; set; } = "";
        public string Email { get; set; } = "";
        public string Role { get; set; } = "User";
        public List<string> Roles { get; set; } = new List<string>();
        public Dictionary<string, string> Claims { get; set; } = new Dictionary<string, string>();
        public string TenantId { get; set; } = ""; // Multi-tenant support
        public bool IsAuthenticated => !string.IsNullOrEmpty(UserId);
    }




}
