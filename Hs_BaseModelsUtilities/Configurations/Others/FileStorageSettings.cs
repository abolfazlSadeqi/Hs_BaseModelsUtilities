namespace Hs_BaseModelsUtilities.Configurations.Others
{
    /// <summary>
    /// File storage and upload settings
    /// </summary>
    public class FileStorageSettings
    {
        public string TempFolder { get; set; } = "/tmp/"; // Temporary folder path
        public string UploadsFolder { get; set; } = "/uploads/"; // Uploads folder
        public string BackupFolder { get; set; } = "/backup/"; // Backup folder
        public string ConfigFolder { get; set; } = "/config/"; // Configuration folder
        public long MaxFileSizeBytes { get; set; } = 10485760; // Maximum file size (10 MB)
        public string DefaultFileAccess { get; set; } = "Private"; // File access type
        public string[] AllowedFileExtensions { get; set; } = new string[] { ".txt", ".pdf", ".docx", ".xlsx", ".jpg", ".png" }; // Allowed file types
    }
}



