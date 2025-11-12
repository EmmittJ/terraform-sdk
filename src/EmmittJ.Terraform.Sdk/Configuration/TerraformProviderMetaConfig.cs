using System.Collections.Generic;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a provider_meta block configuration.
/// Provider metadata allows modules to pass provider-specific information independently of provider configuration.
/// This is typically used by official modules to provide usage statistics to the provider.
/// </summary>
/// <remarks>
/// Reference: https://developer.hashicorp.com/terraform/internals/provider-meta
/// </remarks>
public class TerraformProviderMetaConfig
{
    /// <summary>
    /// The provider name this metadata is for (e.g., "my-provider").
    /// </summary>
    public string ProviderName { get; set; } = string.Empty;

    /// <summary>
    /// The metadata key-value pairs to pass to the provider.
    /// The schema must match what the provider expects.
    /// </summary>
    public Dictionary<string, object?> Metadata { get; set; } = new();

    /// <summary>
    /// Creates a new provider_meta configuration.
    /// </summary>
    public TerraformProviderMetaConfig()
    {
    }

    /// <summary>
    /// Creates a new provider_meta configuration with the specified provider name.
    /// </summary>
    public TerraformProviderMetaConfig(string providerName)
    {
        ProviderName = providerName;
    }

    /// <summary>
    /// Creates a new provider_meta configuration with the specified provider name and metadata.
    /// </summary>
    public TerraformProviderMetaConfig(string providerName, Dictionary<string, object?> metadata)
    {
        ProviderName = providerName;
        Metadata = metadata;
    }

    /// <summary>
    /// Adds or updates a metadata key-value pair.
    /// </summary>
    public TerraformProviderMetaConfig WithMetadata(string key, object? value)
    {
        Metadata[key] = value;
        return this;
    }
}
