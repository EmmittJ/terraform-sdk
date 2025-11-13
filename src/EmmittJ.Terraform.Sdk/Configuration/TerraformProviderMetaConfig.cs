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
public class TerraformProviderMetaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the provider name this metadata is for (e.g., "my-provider").
    /// </summary>
    public string ProviderName { get; }

    /// <summary>
    /// Initializes a new instance of TerraformProviderMetaBlock.
    /// </summary>
    /// <param name="providerName">The provider name this metadata is for.</param>
    public TerraformProviderMetaBlock(string providerName) : base("provider_meta")
    {
        ProviderName = providerName ?? throw new ArgumentNullException(nameof(providerName));
    }

    /// <summary>
    /// Resolves to a labeled block expression: provider_meta "provider_name" { ... }
    /// </summary>
    public override TerraformExpression Resolve(ITerraformContext ctx)
    {
        var bodyMap = base.Resolve(ctx);

        // Create a labeled block: provider_meta "provider_name" { body }
        return new TerraformBlockExpression("provider_meta", [ProviderName], bodyMap);
    }
}
