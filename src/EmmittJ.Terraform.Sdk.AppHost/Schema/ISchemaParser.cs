using EmmittJ.Terraform.Sdk.AppHost.Models;
using EmmittJ.Terraform.Sdk.AppHost.Schema;

namespace EmmittJ.Terraform.Sdk.AppHost;

/// <summary>
/// Parses Terraform provider schema JSON into structured models.
/// </summary>
public interface ISchemaParser
{
    /// <summary>
    /// Parses the provider schema JSON string into a structured model.
    /// </summary>
    ProviderSchemaRoot ParseSchema(string schemaJson);

    /// <summary>
    /// Parses resources from a provider schema.
    /// </summary>
    List<ResourceModel> ParseResources(ProviderSchema providerSchema, string providerName);

    /// <summary>
    /// Parses data sources from a provider schema.
    /// </summary>
    List<ResourceModel> ParseDataSources(ProviderSchema providerSchema, string providerName);
}
