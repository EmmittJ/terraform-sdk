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
    /// This is a nested block, not an attribute assignment.
    /// </summary>
    public TerraformMap<ProviderRequirement>? RequiredProviders
    {
        get => GetArgument<TerraformMap<ProviderRequirement>>("required_providers");
        set => SetArgument("required_providers", value);
    }

    /// <summary>
    /// Gets or sets the provider_meta blocks.
    /// Provider metadata allows modules to pass provider-specific information independently of provider configuration.
    /// </summary>
    public TerraformList<TerraformProviderMetaBlock>? ProviderMetas { get; set; }
}

/// <summary>
/// Represents a provider requirement with source and version constraint.
/// Used within the required_providers block.
/// </summary>
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
