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

    /// <summary>
    /// Parses a block type definition into a block type model.
    /// </summary>
    /// <param name="name">The name of the block type.</param>
    /// <param name="blockType">The schema block type definition.</param>
    /// <param name="parentClassName">The parent class name for nested block references.</param>
    /// <returns>A block type model.</returns>
    BlockTypeModel ParseBlockType(string name, SchemaBlockType blockType, string parentClassName);
}
