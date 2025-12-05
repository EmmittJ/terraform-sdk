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
    /// Gets the Terraform reference identifier for this block (e.g., "aws_vpc.main", "var.region").
    /// Used to build lineage paths for reference tracking.
    /// Returns null for blocks that cannot be referenced (nested blocks, settings blocks).
    /// </summary>
    public virtual string? ReferenceIdentifier => null;

    /// <summary>
    /// Gets or sets the lineage of this block.
    /// When getting, if lineage hasn't been set but ReferenceIdentifier is available,
    /// a lineage is lazily created from ReferenceIdentifier.
    /// </summary>
    public override TerraformLineage? Lineage
    {
        get => field ?? (ReferenceIdentifier is not null ? new TerraformLineage(ReferenceIdentifier) : null);
        set => field = value;
    }

    /// <summary>
    /// Initializes a new instance of TerraformBlock.
    /// </summary>
    protected TerraformBlock() : base()
    {
    }

    /// <summary>
    /// Gets or sets an attribute value. When getting, returns the stored value with lineage attached
    /// (so it resolves to a reference when used elsewhere), or a placeholder reference if not stored.
    /// When setting, stores the value directly.
    /// </summary>
    /// <param name="key">The attribute name.</param>
    /// <returns>The stored value with lineage, or a placeholder reference expression.</returns>
    public new TerraformValue<object> this[string key]
    {
        get
        {
            var lineage = Lineage;

            // If we have a stored value, return it with lineage attached
            if (_elements.TryGetValue(key, out var value))
            {
                return lineage is not null
                    ? value.WithLineage(lineage.WithMember(key))
                    : value;
            }

            // No stored value - create a placeholder reference expression
            if (lineage is null)
            {
                throw new InvalidOperationException(
                    $"Cannot create reference to '{key}' on {GetType().Name}: block type does not support references.");
            }

            return new TerraformValue<object>(lineage.WithMember(key).BuildExpression());
        }
        set => SetArgument(key, value);
    }

    /// <summary>
    /// Creates a reference expression for a computed attribute by extending this block's lineage.
    /// Used by generated property getters for computed attributes.
    /// </summary>
    /// <param name="attributeName">The Terraform attribute name.</param>
    /// <returns>A TerraformExpression that can be implicitly converted to any TerraformValue type.</returns>
    /// <exception cref="InvalidOperationException">Thrown when the block has no lineage and no reference identifier.</exception>
    protected TerraformExpression CreateReference(string attributeName)
    {
        var lineage = Lineage
            ?? throw new InvalidOperationException(
                $"Cannot create reference to '{attributeName}' on {GetType().Name}: block has no lineage or reference identifier.");

        return lineage.WithMember(attributeName).BuildExpression();
    }

    /// <summary>
    /// Creates a reference expression for this block (e.g., <c>var.region</c>, <c>aws_vpc.main</c>).
    /// Used when the block itself needs to be referenced in expressions.
    /// </summary>
    /// <returns>A TerraformExpression representing a reference to this block.</returns>
    /// <exception cref="InvalidOperationException">
    /// Thrown when the block has no lineage or no reference identifier.
    /// </exception>
    public TerraformExpression ToReference()
    {
        var lineage = Lineage
            ?? throw new InvalidOperationException(
                $"Cannot create reference to {GetType().Name}: block type does not support references.");

        return lineage.BuildExpression();
    }    /// <summary>
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
