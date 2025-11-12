namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform provider configuration - a top-level construct for configuring providers.
/// Inherits from TerraformBlock to reuse property storage and expression infrastructure.
/// </summary>
/// <remarks>
/// Providers are plugins that Terraform uses to create and manage resources.
/// Each provider adds a set of resource types and/or data sources that Terraform can manage.
/// </remarks>
public partial class TerraformProvider : TerraformBlock, ITerraformTopLevelBlock
{
    /// <summary>
    /// Gets the provider name.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Gets the block type keyword for providers.
    /// </summary>
    public string BlockType => "provider";

    /// <summary>
    /// Gets the block labels for this provider.
    /// </summary>
    public string[] BlockLabels => [Name];

    /// <summary>
    /// Initializes a new instance of TerraformProvider.
    /// </summary>
    /// <param name="name">The provider name (e.g., "aws", "azurerm").</param>
    public TerraformProvider(string name) : base("")
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }

    /// <summary>
    /// Gets or sets the alias for this provider instance.
    /// </summary>
    [TerraformProperty("alias")]
    public TerraformValue<string>? Alias { get; set; }

    /// <summary>
    /// Resolves to a TerraformConstructExpression representing the provider block.
    /// Overrides the base Resolve() to return a construct expression instead of a map expression.
    /// </summary>
    /// <param name="ctx">The resolution context.</param>
    /// <returns>A TerraformConstructExpression with block type "provider" and label [name].</returns>
    public override TerraformExpression Resolve(ITerraformContext ctx)
    {
        // Get map expression from properties (via base.Resolve())
        var bodyMap = base.Resolve(ctx);

        // Wrap in construct expression with provider name
        return new TerraformConstructExpression("provider", [Name], bodyMap);
    }

    /// <summary>
    /// Generates a reference to this provider.
    /// Used when specifying provider configuration in resources or data sources.
    /// </summary>
    /// <returns>An identifier expression for this provider.</returns>
    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier(Name);
}
