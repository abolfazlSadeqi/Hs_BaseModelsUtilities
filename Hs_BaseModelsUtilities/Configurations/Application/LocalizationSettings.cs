namespace Hs_BaseModelsUtilities.Configurations.Application
{
    /// <summary>
    /// Localization and supported cultures
    /// </summary>
    public class LocalizationSettings
    {
        public string DefaultCulture { get; set; } = "en-US"; // Default culture
        public string[] SupportedCultures { get; set; } = new[] { "en-US", "fa-IR" }; // Supported cultures
        public bool EnableFallback { get; set; } = true; // Enable fallback culture
    }
}



