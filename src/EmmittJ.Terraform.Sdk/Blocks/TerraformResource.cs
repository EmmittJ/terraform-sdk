namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform resource - a top-level block with type, name, and meta-arguments.
/// Inherits from TerraformBlock to reuse property storage and expression infrastructure.
/// </summary>
/// <remarks>
/// Resources are the most important element in Terraform. Each resource block describes one or more
/// infrastructure objects, such as virtual networks, compute instances, or higher-level components
/// such as DNS records.
/// </remarks>
public partial class TerraformResource : TerraformBlock, ITerraformTopLevelBlock,
    ITerraformHasCount,
    ITerraformHasForEach,
    ITerraformHasDependsOn,
    ITerraformHasProvider,
    ITerraformHasLifecycle,
    ITerraformHasDynamicBlocks
{
    /// <summary>
    /// Gets the resource type (e.g., "aws_vpc", "azurerm_resource_group").
    /// </summary>
    public string ResourceType { get; }

    /// <summary>
    /// Gets the resource name (unique within the configuration).
    /// </summary>
    public string ResourceName { get; }

    /// <summary>
    /// Gets the block type keyword for resources.
    /// </summary>
    public string BlockType => "resource";

    /// <summary>
    /// Gets the block labels for this resource.
    /// </summary>
    public string[] BlockLabels => [ResourceType, ResourceName];

    /// <summary>
    /// Initializes a new instance of TerraformResource.
    /// </summary>
    /// <param name="type">The resource type (e.g., "aws_vpc").</param>
    /// <param name="name">The resource name.</param>
    public TerraformResource(string type, string name) : base("")
    {
        ResourceType = type ?? throw new ArgumentNullException(nameof(type));
        ResourceName = name ?? throw new ArgumentNullException(nameof(name));
    }

    /// <summary>
    /// Resolves to a TerraformBlockExpression representing the resource block.
    /// Overrides the base Resolve() to return a block expression instead of a map expression.
    /// </summary>
    /// <param name="ctx">The resolution context.</param>
    /// <returns>A TerraformBlockExpression with block type "resource" and labels [type, name].</returns>
    public override TerraformExpression Resolve(ITerraformContext ctx)
    {
        // Get map expression from properties (via base.Resolve())
        var bodyMap = base.Resolve(ctx);

        // Wrap in block expression with resource type and name
        return new TerraformBlockExpression("resource",
            [ResourceType, ResourceName], bodyMap);
    }

    /// <summary>
    /// Generates a reference to this resource (e.g., "aws_vpc.main").
    /// Used when referencing this resource's attributes in other parts of the configuration.
    /// </summary>
    /// <returns>An identifier expression for this resource.</returns>
    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier($"{ResourceType}.{ResourceName}");
}
