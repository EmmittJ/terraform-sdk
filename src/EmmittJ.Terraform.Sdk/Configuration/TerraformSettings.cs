using System.Linq;
using System.Text;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents the terraform {} settings block.
/// This is a top-level Terraform block that configures Terraform itself.
/// </summary>
public partial class TerraformSettings : TerraformBlock, ITerraformTopLevelBlock, ITerraformPreparable
{
    /// <summary>
    /// Gets the block type keyword for the terraform block.
    /// </summary>
    public string BlockType => "terraform";

    /// <summary>
    /// Gets the block labels for the terraform block (none).
    /// </summary>
    public string[] BlockLabels => [];

    /// <summary>
    /// Initializes a new instance of TerraformSettings.
    /// </summary>
    public TerraformSettings() : base("") { }

    /// <summary>
    /// Gets or sets the required Terraform version constraint (e.g., ">= 1.0", "~> 1.5.0").
    /// </summary>
    [TerraformArgument("required_version")]
    public partial TerraformValue<string>? RequiredVersion { get; set; }

    /// <summary>
    /// Gets or sets the backend configuration for remote state storage.
    /// Backend is a block expression with a label.
    /// </summary>
    [TerraformArgument("backend")]
    public partial TerraformValue<TerraformBackend>? Backend { get; set; }

    /// <summary>
    /// Gets or sets the cloud block configuration (for Terraform Cloud/Enterprise).
    /// Mutually exclusive with Backend.
    /// </summary>
    [TerraformArgument("cloud")]
    public partial TerraformCloudBlock? Cloud { get; set; }

    /// <summary>
    /// Gets or sets the experiments list - experimental features to enable.
    /// </summary>
    [TerraformArgument("experiments")]
    public partial TerraformList<string>? Experiments { get; set; }

    /// <summary>
    /// Gets or sets the required_providers block as a map.
    /// Each key is the local provider name, value is the provider requirement.
    /// </summary>
    [TerraformArgument("required_providers")]
    public partial TerraformMap<ProviderRequirement>? RequiredProviders { get; set; }

    /// <summary>
    /// Gets or sets the provider_meta blocks.
    /// Provider metadata allows modules to pass provider-specific information independently of provider configuration.
    /// </summary>
    public TerraformList<TerraformProviderMetaBlock>? ProviderMetas { get; set; }

    /// <inheritdoc />
    public void Prepare(ITerraformContext context)
    {
        if (context == null)
        {
            throw new ArgumentNullException(nameof(context));
        }

        // Prepare any nested blocks if needed
        // This is called during the prepare phase of the stack compilation
    }

    /// <summary>
    /// Resolves to a TerraformBlockExpression representing the terraform block.
    /// </summary>
    public override TerraformExpression Resolve(ITerraformContext ctx)
    {
        // Get map expression from properties (via base.Resolve())
        var bodyMap = base.Resolve(ctx);

        // Wrap in block expression with "terraform" block type and no labels
        return new TerraformBlockExpression("terraform", [], bodyMap);
    }
}

/// <summary>
/// Represents a provider requirement with source and version constraint.
/// Used within the required_providers block.
/// </summary>
public partial class ProviderRequirement : TerraformBlock
{
    /// <summary>
    /// Initializes a new instance of ProviderRequirement.
    /// </summary>
    public ProviderRequirement() : base("") { }

    /// <summary>
    /// Gets or sets the provider source (e.g., "hashicorp/aws", "hashicorp/azurerm").
    /// </summary>
    [TerraformArgument("source")]
    public required partial TerraformValue<string> Source { get; set; }

    /// <summary>
    /// Gets or sets the version constraint (e.g., "~> 5.0", ">= 4.0.0").
    /// </summary>
    [TerraformArgument("version")]
    public partial TerraformValue<string>? Version { get; set; }
}
