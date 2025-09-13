using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hs_BaseModelsUtilities.Configurations.Security
{

    /// <summary>
    /// General application-level settings including environment, base URL, and default culture/timezone
    /// </summary>
    public class AppSettings
    {
        public string AppName { get; set; } = "MyEnterpriseApp"; // Application name
        public string AppVersion { get; set; } = "1.0.0"; // Current version
        public string Environment { get; set; } = "Development"; // Environment (Development, Staging, Production)
        public string BaseUrl { get; set; } = "http://localhost:5000"; // Base URL for API
        public string HostName { get; set; } = "localhost"; // Host name
        public int Port { get; set; } = 5000; // Port number
        public string DefaultCulture { get; set; } = "en-US"; // Default culture
        public string DefaultTimeZone { get; set; } = "UTC"; // Default timezone


    }
}



