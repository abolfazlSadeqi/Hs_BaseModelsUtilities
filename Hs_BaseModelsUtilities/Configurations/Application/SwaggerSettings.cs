namespace Hs_BaseModelsUtilities.Configurations.Application
{
    /// <summary>
    /// Swagger / OpenAPI configuration
    /// </summary>
    public class SwaggerSettings
    {
        public string Title { get; set; } = "My API"; // API title
        public string Version { get; set; } = "v1"; // API version
        public string RoutePrefix { get; set; } = "swagger"; // Route prefix for Swagger UI
        public bool EnableAuth { get; set; } = true; // Enable authentication in Swagger
    }
}



