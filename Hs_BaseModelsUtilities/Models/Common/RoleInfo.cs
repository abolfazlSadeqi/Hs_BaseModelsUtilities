namespace Hs_BaseModelsUtilities.Models.Common

{
    /// <summary>
    /// Role and permission information
    /// </summary>
    public class RoleInfo
    {
        public string RoleName { get; set; } = "User";
        public string Description { get; set; } = "";
        public string[] Permissions { get; set; } = new string[] { "read" };
    }




}
