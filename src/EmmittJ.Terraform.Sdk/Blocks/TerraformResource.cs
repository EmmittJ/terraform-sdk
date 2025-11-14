using System.Text;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform resource - a top-level block with type, name, and meta-arguments.
/// Inherits from TerraformBlock to reuse property storage and expression infrastructure.
/// </summary>
/// <remarks>
/// Resources are the most important element in Terraform. Each resource block describes one or more
/// infrastructure objects, such as virtual networks, compute instances, or higher-level components
/// such as DNS records.
/// <para>Spec: <see href="https://developer.hashicorp.com/terraform/language/resources"/></para>
/// </remarks>
public partial class TerraformResource : TerraformBlock,
    ITerraformHasCount,
    ITerraformHasForEach,
    ITerraformHasDependsOn,
    ITerraformHasProvider,
    ITerraformHasLifecycle
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
    public override string BlockType => "resource";

    /// <summary>
    /// Gets the block labels for this resource.
    /// </summary>
    public override string[] BlockLabels => [ResourceType, ResourceName];

    /// <summary>
    /// Initializes a new instance of TerraformResource.
    /// </summary>
    /// <param name="type">The resource type (e.g., "aws_vpc").</param>
    /// <param name="name">The resource name.</param>
    public TerraformResource(string type, string name)
    {
        ResourceType = type ?? throw new ArgumentNullException(nameof(type));
        ResourceName = name ?? throw new ArgumentNullException(nameof(name));
    }

    /// <summary>
    /// Generates a reference to this resource (e.g., "aws_vpc.main").
    /// This reference can be used to access the resource's attributes (output values like id, arn, etc.)
    /// in other parts of the configuration.
    /// </summary>
    /// <returns>An identifier expression for this resource.</returns>
    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier($"{ResourceType}.{ResourceName}");

    /// <summary>
    /// Resolves this resource to a top-level block node.
    /// </summary>
    public override IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context)
    {
        var children = base.ResolveNodes(context).ToList();
        yield return new TerraformBlockNode(BlockType, BlockLabels, children);
    }
}
