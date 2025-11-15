using System.Text;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform provider configuration - a top-level block for configuring providers.
/// Inherits from TerraformBlock to reuse property storage and expression infrastructure.
/// </summary>
/// <remarks>
/// Providers are plugins that Terraform uses to create and manage resources.
/// Each provider adds a set of resource types and/or data sources that Terraform can manage.
/// <para>Spec: <see href="https://developer.hashicorp.com/terraform/language/block/provider"/></para>
/// </remarks>
public partial class TerraformProvider : TerraformBlock
{
    /// <summary>
    /// Gets the provider name.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Gets the block type keyword for providers.
    /// </summary>
    public override string BlockType => "provider";

    /// <summary>
    /// Gets the block labels (just the provider name).
    /// </summary>
    public override string[] BlockLabels => [Name];

    /// <summary>
    /// Initializes a new instance of TerraformProvider.
    /// </summary>
    /// <param name="name">The provider name (e.g., "aws", "azurerm").</param>
    public TerraformProvider(string name)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }

    /// <summary>
    /// Gets or sets the alias for this provider instance.
    /// </summary>
    [TerraformArgument("alias")]
    public TerraformValue<string>? Alias { get; set; }

    /// <summary>
    /// Generates a reference to this provider.
    /// Used when specifying provider configuration in resources or data sources.
    /// </summary>
    /// <returns>An identifier expression for this provider.</returns>
    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier(Name);

    /// <summary>
    /// Resolves this provider to a top-level block node.
    /// </summary>
    public override IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context)
    {
        var children = base.ResolveNodes(context).ToList();
        yield return new TerraformBlockNode(BlockType, BlockLabels, children);
    }
}
