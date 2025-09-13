namespace Hs_BaseModelsUtilities.Configurations.Others
{
    /// <summary>
    /// Default roles and permissions
    /// </summary>
    public class RolePermissionSettings
    {
        public string AdminRole { get; set; } = "Admin"; // Admin role
        public string UserRole { get; set; } = "User"; // Standard user role
        public string ReadOnlyRole { get; set; } = "ReadOnly"; // Read-only role
        public string GuestRole { get; set; } = "Guest"; // Guest role
        public string SuperAdminRole { get; set; } = "SuperAdmin"; // Super admin role
        public string[] DefaultPermissions { get; set; } = new string[] { "read", "write", "delete" }; // Default permissions
    }
}



