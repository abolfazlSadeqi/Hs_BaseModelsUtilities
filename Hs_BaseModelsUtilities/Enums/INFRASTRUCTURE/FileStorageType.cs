namespace Hs_BaseModelsUtilities.Enums.INFRASTRUCTURE
{
    /// <summary>
    /// File storage providers.
    /// </summary>
    public enum FileStorageType
        {
            Local = 1,
            S3 = 2,
            AzureBlob = 3,
            GoogleCloudStorage = 4,
            FTP = 5,
            InMemory = 6
        }
    }
