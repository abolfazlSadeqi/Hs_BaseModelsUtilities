namespace Hs_BaseModelsUtilities.Configurations.Others
{
    /// <summary>
    /// SMTP settings for sending emails
    /// </summary>
    public class SmtpSettings
    {
        public string Host { get; set; } = "smtp.mailserver.com"; // SMTP host
        public int Port { get; set; } = 587; // SMTP port
        public string UserName { get; set; } = "user@mailserver.com"; // Username
        public string Password { get; set; } = "YourEmailPassword"; // Password
        public bool EnableSsl { get; set; } = true; // Enable SSL
        public string FromEmail { get; set; } = "no-reply@mailserver.com"; // Default from email
        public string FromName { get; set; } = "MyApp"; // Sender name
        public int TimeoutSeconds { get; set; } = 30; // SMTP timeout
        public bool UsePickupDirectory { get; set; } = false; // Use pickup directory instead of SMTP
    }
}



