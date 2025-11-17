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
/// </remarks>
public abstract class TerraformBlock : TerraformMap<object>
{
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
    /// Indexer for block property access.
    /// Getter returns a reference to the property for resource/block attribute references.
    /// Setter delegates to base TerraformMap.SetArgument which handles ITerraformValue unwrapping.
    /// </summary>
    /// <param name="key">The property name.</param>
    /// <returns>A reference to the property that resolves to the correct HCL identifier.</returns>
    public new TerraformValue<object> this[string key]
    {
        get => new TerraformReference<object>(this, key);
        set => base[key] = value;
    }

    /// <summary>
    /// Creates a reference expression to this block.
    /// Default implementation returns a simple identifier.
    /// Override in derived classes to provide specific reference formats (e.g., "resource.type.name").
    /// </summary>
    public virtual TerraformExpression AsReference()
        => TerraformExpression.Identifier(BlockType);

    /// <summary>
    /// Resolves this block to multiple syntax nodes (arguments + nested blocks).
    /// Nodes are sorted by the context's formatter.
    /// </summary>
    public override IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context)
    {
        var nodes = new List<TerraformSyntaxNode>();

        foreach (var (key, terraformValue) in _elements)
        {
            if (terraformValue.Resolvable is TerraformBlock nestedBlock)
            {
                // Nested blocks resolve themselves to complete BlockNode(s)
                // Don't wrap them again - just add the resolved nodes directly
                nodes.AddRange(nestedBlock.ResolveNodes(context));
            }
            // Otherwise it's an argument value - resolve to expression
            else
            {
                var resolvedNodes = terraformValue.ResolveNodes(context).ToList();

                if (resolvedNodes.Count == 1 && resolvedNodes[0] is TerraformExpression expr)
                {
                    nodes.Add(new TerraformArgumentNode(key, expr));
                }
                else
                {
                    // Fallback: add all resolved nodes (shouldn't happen in normal cases)
                    nodes.AddRange(resolvedNodes);
                }
            }
        }

        // Format nodes using the context's formatter
        var formatted = context.Formatter.Format(nodes);

        // Wrap the formatted children in a block node with this block's type and labels
        yield return new TerraformBlockNode(BlockType, BlockLabels, formatted);
    }
}
