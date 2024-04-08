namespace Databrowser.Configuration.Constants
{
    public static class ODataConfiguration
    {
        public const string RoutePrefix = "odata";
        public const string ODataNamespace = "DataPlatform";
        public const string SwaggerDocVersion = "v1";
        public const string SwaggerDocDescription = "Swagger OData Demo";
        public const string SwaggerDocTitle = "DataPlatform OData Demo API";
        public const string ApiVersionHeaderName = "Api-Version";
        public const string EnvConnectionString = "CONNECTION_STRING";
        public const string EnvConnectionStringProperty = "Postgres";
        public const string SwaggerPath = "/odata/{documentName}/swagger.json";
        public const string SwaggerEndPointUrl = "/odata/v1/swagger.json";
        public const string SwaggerEndPointName = "DataPlatform API";
    }
}