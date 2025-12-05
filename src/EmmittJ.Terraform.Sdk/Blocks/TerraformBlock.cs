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
            // If we have a stored value, return it with lineage attached
            if (_elements.TryGetValue(key, out var value))
            {
                // Build the lineage for this attribute if we have block lineage
                if (Lineage is not null)
                {
                    // Use WithMember for block attributes (not WithKey like maps)
                    return value.WithLineage(Lineage.WithMember(key));
                }
                // No lineage yet, but we can still build a reference from ReferenceIdentifier
                if (ReferenceIdentifier is not null)
                {
                    var refLineage = new TerraformLineage(ReferenceIdentifier).WithMember(key);
                    return value.WithLineage(refLineage);
                }
                return value;
            }

            // No stored value - create a placeholder reference expression
            if (ReferenceIdentifier is null)
            {
                throw new InvalidOperationException(
                    $"Cannot create reference to '{key}' on {GetType().Name}: block type does not support references.");
            }

            // Build reference expression from lineage or reference identifier
            TerraformExpression expr;
            if (Lineage is not null)
            {
                expr = Lineage.WithMember(key).BuildExpression();
            }
            else
            {
                expr = new TerraformLineage(ReferenceIdentifier).WithMember(key).BuildExpression();
            }

            return new TerraformValue<object>(expr);
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
        // Use lineage if available, otherwise fall back to ReferenceIdentifier
        if (Lineage is not null)
        {
            return Lineage.WithMember(attributeName).BuildExpression();
        }

        if (ReferenceIdentifier is not null)
        {
            return new TerraformLineage(ReferenceIdentifier).WithMember(attributeName).BuildExpression();
        }

        throw new InvalidOperationException(
            $"Cannot create reference to '{attributeName}' on {GetType().Name}: block has no lineage or reference identifier.");
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
        if (ReferenceIdentifier is null)
        {
            throw new InvalidOperationException(
                $"Cannot create reference to {GetType().Name}: block type does not support references.");
        }

        if (Lineage is null)
        {
            // Return identifier-based reference when block hasn't been added to a stack yet
            return TerraformExpression.Identifier(ReferenceIdentifier);
        }

        return Lineage.BuildExpression();
    }

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
