namespace Hs_BaseModelsUtilities.Constants
{
 

    public static class CacheKeys
    {
        public const string UserProfile = "Cache_UserProfile_";
        public const string RolePermissions = "Cache_RolePermissions_";
        public const string SystemSettings = "Cache_SystemSettings";
        public const string FeatureToggles = "Cache_FeatureToggles";
        public const string ExpirationShortSeconds = "300"; // 5 minutes
        public const string ExpirationMediumSeconds = "3600"; // 1 hour
        public const string ExpirationLongSeconds = "86400"; // 1 day
    }


}
