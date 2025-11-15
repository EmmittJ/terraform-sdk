using System.Collections.Generic;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a provider_meta block configuration.
/// Provider metadata allows modules to pass provider-specific information independently of provider configuration.
/// This is typically used by official modules to provide usage statistics to the provider.
/// </summary>
/// <remarks>
/// <para>Spec: <see href="https://developer.hashicorp.com/terraform/language/meta-arguments/provider"/></para>
/// </remarks>
public class TerraformProviderMetaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "provider_meta";

    /// <summary>
    /// Gets the provider name this metadata is for (e.g., "my-provider").
    /// </summary>
    public string ProviderName { get; }

    /// <summary>
    /// Initializes a new instance of TerraformProviderMetaBlock.
    /// </summary>
    /// <param name="providerName">The provider name this metadata is for.</param>
    public TerraformProviderMetaBlock(string providerName)
    {
        ProviderName = providerName ?? throw new ArgumentNullException(nameof(providerName));
    }

    /// <summary>
    /// Cannot generate reference to provider_meta blocks.
    /// </summary>
    public override TerraformExpression AsReference()
        => throw new NotSupportedException("Provider meta blocks cannot be referenced.");
}
