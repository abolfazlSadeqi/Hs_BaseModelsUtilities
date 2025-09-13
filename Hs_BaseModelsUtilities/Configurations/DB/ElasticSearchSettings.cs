namespace Hs_BaseModelsUtilities.Configurations.DB
{
    /// <summary>
    /// ElasticSearch configuration settings
    /// </summary>
    public class ElasticSearchSettings
    {
        public string Uri { get; set; } = "http://localhost:9200"; // ElasticSearch server URI
        public string DefaultIndex { get; set; } = "myapp-index"; // Default index name
        public bool EnableSniffing { get; set; } = true; // Enable sniffing
        public bool EnableAuthentication { get; set; } = false; // Enable basic authentication
        public string Username { get; set; } = ""; // Username for auth
        public string Password { get; set; } = ""; // Password for auth
    }
}



