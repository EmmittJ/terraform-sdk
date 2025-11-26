using System.Linq;
using System.Text;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents the terraform {} settings block.
/// This is a top-level Terraform block that configures Terraform itself.
/// </summary>
/// <remarks>
/// <para>Spec: <see href="https://developer.hashicorp.com/terraform/language/block/terraform"/></para>
/// </remarks>
public partial class TerraformSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type keyword for the terraform block.
    /// </summary>
    public override string BlockType => "terraform";

    /// <summary>
    /// Gets the block labels (terraform blocks have none).
    /// </summary>
    public override string[] BlockLabels => [];

    /// <summary>
    /// Initializes a new instance of TerraformSettings.
    /// </summary>
    public TerraformSettingsBlock() { }

    /// <summary>
    /// Gets or sets the required Terraform version constraint (e.g., ">= 1.0", "~> 1.5.0").
    /// </summary>
    public TerraformValue<string>? RequiredVersion
    {
        get => GetArgument<TerraformValue<string>?>("required_version");
        set => SetArgument("required_version", value);
    }

    /// <summary>
    /// Gets or sets the backend configuration for remote state storage.
    /// This is a nested block.
    /// </summary>
    public TerraformBackendBlock? Backend
    {
        get => GetArgument<TerraformBackendBlock?>("backend");
        set => SetArgument("backend", value);
    }

    /// <summary>
    /// Gets or sets the cloud block configuration (for Terraform Cloud/Enterprise).
    /// Mutually exclusive with Backend.
    /// </summary>
    public TerraformCloudBlock? Cloud
    {
        get => GetArgument<TerraformCloudBlock?>("cloud");
        set => SetArgument("cloud", value);
    }

    /// <summary>
    /// Gets or sets the experiments list - experimental features to enable.
    /// </summary>
    public TerraformList<string>? Experiments
    {
        get => GetArgument<TerraformList<string>?>("experiments");
        set => SetArgument("experiments", value);
    }

    /// <summary>
    /// Gets or sets the required_providers block.
    /// </summary>
    /// <remarks>
    /// <para>See: <see href="https://developer.hashicorp.com/terraform/language/block/terraform#required_providers"/></para>
    /// <example>
    /// <code>
    /// settings.RequiredProviders = new TerraformRequiredProvidersBlock
    /// {
    ///     ["azurerm"] = new ProviderRequirement
    ///     {
    ///         Source = "hashicorp/azurerm",
    ///         Version = "~> 4.0"
    ///     }
    /// };
    /// </code>
    /// </example>
    /// </remarks>
    public TerraformRequiredProvidersBlock? RequiredProviders
    {
        get => GetArgument<TerraformRequiredProvidersBlock?>("required_providers");
        set => SetArgument("required_providers", value);
    }

    /// <summary>
    /// Gets or sets the provider_meta blocks.
    /// Provider metadata allows modules to pass provider-specific information independently of provider configuration.
    /// </summary>
    public TerraformList<TerraformProviderMetaBlock>? ProviderMetas { get; set; }
}

/// <summary>
/// Represents the required_providers block within terraform settings.
/// This block contains provider requirements as assignments (provider_name = { source, version }).
/// </summary>
/// <remarks>
/// <para>See: <see href="https://developer.hashicorp.com/terraform/language/block/terraform#required_providers"/></para>
/// <example>
/// Example HCL output:
/// <code>
/// required_providers {
///   azurerm = {
///     source  = "hashicorp/azurerm"
///     version = "~> 4.0"
///   }
/// }
/// </code>
/// </example>
/// </remarks>
public class TerraformRequiredProvidersBlock : TerraformBlock
{
    private readonly Dictionary<string, ProviderRequirement> _providers = new();

    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "required_providers";

    /// <summary>
    /// Gets or sets a provider requirement by name.
    /// </summary>
    /// <param name="providerName">The local name for the provider (e.g., "azurerm", "aws").</param>
    /// <returns>The provider requirement.</returns>
    public new ProviderRequirement this[string providerName]
    {
        get => _providers[providerName];
        set => _providers[providerName] = value;
    }

    /// <summary>
    /// Adds a provider requirement.
    /// </summary>
    /// <param name="providerName">The local name for the provider.</param>
    /// <param name="requirement">The provider requirement.</param>
    public void Add(string providerName, ProviderRequirement requirement)
    {
        _providers[providerName] = requirement;
    }

    /// <summary>
    /// Resolves to a block node containing provider assignments.
    /// </summary>
    public override IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context)
    {
        var nodes = new List<TerraformSyntaxNode>();

        foreach (var (providerName, requirement) in _providers)
        {
            // Resolve the ProviderRequirement to a map expression
            var requirementNodes = ((TerraformMap<string>)requirement).ResolveNodes(context).ToList();
            if (requirementNodes.FirstOrDefault() is TerraformExpression expr)
            {
                nodes.Add(new TerraformArgumentNode(providerName, expr));
            }
        }

        yield return new TerraformBlockNode(BlockType, BlockLabels, nodes);
    }
}

/// <summary>
/// Represents a provider requirement with source and version constraint.
/// Used within the required_providers block.
/// </summary>
/// <remarks>
/// <example>
/// <code>
/// new ProviderRequirement
/// {
///     Source = "hashicorp/azurerm",
///     Version = "~> 4.0"
/// }
/// </code>
/// Generates:
/// <code>
/// {
///   source  = "hashicorp/azurerm"
///   version = "~> 4.0"
/// }
/// </code>
/// </example>
/// </remarks>
public partial class ProviderRequirement : TerraformMap<string>
{
    /// <summary>
    /// Gets or sets the provider source (e.g., "hashicorp/aws", "hashicorp/azurerm").
    /// </summary>
    public required TerraformValue<string> Source
    {
        get => GetRequiredArgument<TerraformValue<string>>("source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// Gets or sets the version constraint (e.g., "~> 5.0", ">= 4.0.0").
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>?>("version");
        set => SetArgument("version", value);
    }
}
