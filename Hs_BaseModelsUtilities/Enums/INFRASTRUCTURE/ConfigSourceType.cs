namespace Hs_BaseModelsUtilities.Enums.INFRASTRUCTURE
{
    /// <summary>
    /// Sources for application configuration.
    /// </summary>
    public enum ConfigSourceType
        {
            JsonFile = 1,
            XmlFile = 2,
            EnvironmentVariable = 3,
            CommandLine = 4,
            Vault = 5,
            Database = 6,
            RemoteConfigService = 7
        }
    }
