namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Base class for Terraform nested block objects.
/// Provides property storage infrastructure for source-generated properties.
/// Inherits from TerraformMap&lt;object&gt; which provides map storage and resolution infrastructure.
/// All generated block classes should inherit from this.
/// </summary>
/// <remarks>
/// Blocks inherit from TerraformMap&lt;object&gt; primarily for property storage and resolution.
/// The map-like interface (indexer, Add methods) is not typically used directly in block classes.
/// This design maximizes code reuse of the TerraformMap infrastructure without duplicating
/// property storage logic.
/// <para>
/// Nested blocks automatically track their parent via <see cref="ITerraformHasParent"/> to enable
/// reference chaining. When a nested block is assigned to a parent's property, the parent is
/// automatically set by <see cref="TerraformMap{T}.SetArgument"/>.
/// </para>
/// </remarks>
public abstract class TerraformBlock : TerraformMap<object>, ITerraformReferenceable, ITerraformHasParent
{
    /// <summary>
    /// Gets or sets the parent block for reference chaining.
    /// Automatically set when this block is assigned to a parent's property.
    /// </summary>
    public ITerraformReferenceable? ParentBlock { get; set; }

    /// <summary>
    /// Gets or sets the attribute name this block was assigned to in the parent.
    /// Automatically set when this block is assigned to a parent's property via SetArgument.
    /// </summary>
    public string? ParentAttributeName { get; set; }

    /// <summary>
    /// Gets the block type keyword (e.g., "resource", "data", "lifecycle", "timeouts").
    /// For top-level blocks, this is the first keyword ("resource", "data", "provider").
    /// For nested blocks, this is the block name ("lifecycle", "timeouts", "tags").
    /// </summary>
    public abstract string BlockType { get; }

    /// <summary>
    /// Gets the block labels (e.g., ["aws_vpc", "main"] for resources).
    /// Returns empty array for blocks without labels.
    /// </summary>
    public virtual string[] BlockLabels => [];

    /// <summary>
    /// Initializes a new instance of TerraformBlock.
    /// </summary>
    protected TerraformBlock() : base()
    {
    }

    /// <summary>
    /// Creates a reference expression to this block.
    /// For nested blocks, chains through the parent's reference.
    /// For top-level blocks (resources, data sources), override this to return the appropriate reference.
    /// </summary>
    /// <returns>
    /// A <see cref="TerraformExpression"/> that represents a reference to this block.
    /// </returns>
    /// <exception cref="InvalidOperationException">
    /// Thrown when attempting to reference a nested block without a parent.
    /// </exception>
    public virtual TerraformExpression AsReference()
    {
        if (ParentBlock is null)
        {
            throw new InvalidOperationException(
                $"Cannot create reference to nested block {GetType().Name} without a parent. " +
                "Nested blocks must be assigned to a parent resource or data source before they can be referenced.");
        }

        return ParentBlock.AsReference().Member(BlockType);
    }

    /// <summary>
    /// Creates a reference to a specific attribute of this block.
    /// </summary>
    /// <param name="name">The attribute name.</param>
    /// <returns>A reference expression to the attribute.</returns>
    /// <example>
    /// <code>
    /// // For a resource:
    /// var vpc = new TerraformResource("aws_vpc", "main");
    /// var vpcId = vpc.AsReference("id");  // aws_vpc.main.id
    ///
    /// // For nested blocks:
    /// var fqdn = containerApp.Ingress.Index(0).AsReference("fqdn");
    /// </code>
    /// </example>
    public virtual TerraformExpression AsReference(string name)
        => AsReference().Member(name);

    /// <summary>
    /// Resolves this block to multiple syntax nodes (arguments + nested blocks).
    /// Nodes are sorted by the context's formatter.
    /// </summary>
    public override IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context)
    {
        var nodes = new List<TerraformSyntaxNode>();

        foreach (var (key, terraformValue) in _elements)
        {
            var resolved = terraformValue.ResolveNodes(context).ToList();
            foreach (var node in resolved)
            {
                if (node is TerraformExpression)
                {
                    // Wrap in argument node
                    nodes.Add(new TerraformArgumentNode(key, node));
                }
                else
                {
                    // Already a dynamic block, block or argument node - add directly
                    nodes.Add(node);
                }
            }
        }

        // Format nodes using the context's formatter
        var formatted = context.Formatter.Format(nodes);

        // Wrap the formatted children in a block node with this block's type and labels
        yield return new TerraformBlockNode(BlockType, BlockLabels, formatted);
    }
}
