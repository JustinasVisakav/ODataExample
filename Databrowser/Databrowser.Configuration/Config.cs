using Microsoft.Extensions.Configuration;
using Databrowser.Configuration.Interfaces;
using System.Diagnostics.CodeAnalysis;

namespace Databrowser.Configuration
{
    [ExcludeFromCodeCoverage]
    public class Config : IConfig
    {
        private readonly IConfiguration databaseSchemaSubsetConfig;

        private const string databaseSchemaSubsetConfigName = "DatabaseSchemas";

        //Database schema config
        private const string databaseSchemaConfigAlias = "DatabaseSchemaSubset";

        public Config(IConfiguration config)
        {
            databaseSchemaSubsetConfig = config.GetSection(databaseSchemaSubsetConfigName);
        }

        //Database schema config
        public string DatabaseSchemaSubset => GetValue(databaseSchemaSubsetConfig, databaseSchemaConfigAlias);

        private static string GetValue(IConfiguration config, string key, string? envValue = null)
        {
            string? value = null;
            if (envValue is not null)
                value = Environment.GetEnvironmentVariable(envValue);

            if (string.IsNullOrWhiteSpace(value))
                value = config.GetSection(key)?.Value;

            return value;
        }
    }
}
