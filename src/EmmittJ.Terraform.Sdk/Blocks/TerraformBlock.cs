namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Base class for Terraform nested block objects.
/// Provides property storage infrastructure for source-generated properties.
/// Inherits from TerraformMap&lt;object&gt; which provides map storage and resolution infrastructure.
/// All generated block classes should inherit from this.
/// </summary>
/// <remarks>
/// Note: While blocks inherit from TerraformMap&lt;object&gt;, they are primarily used for their
/// property storage and resolution capabilities. The map-like interface (indexer, Add methods)
/// is not typically used directly in block classes. This design allows maximum code reuse
/// of the existing TerraformMap infrastructure without duplicating property storage logic.
/// TerraformBlock uses a different approach (direct Dictionary storage) which will be
/// unified in a future refactoring.
/// </remarks>
public abstract class TerraformBlock : TerraformMap<object>
{
    /// <summary>
    /// Gets the Terraform block label (e.g., "timeouts", "tags").
    /// This is set during construction and used during HCL serialization.
    /// For top-level blocks, this may be empty. Can be overridden by derived classes.
    /// </summary>
    internal protected virtual string? BlockLabel { get; }

    /// <summary>
    /// Initializes a new instance of TerraformBlock.
    /// </summary>
    /// <param name="blockLabel">The Terraform block label (e.g., "timeouts"). Can be empty for top-level blocks.</param>
    protected TerraformBlock(string blockLabel = "") : base()
    {
        BlockLabel = blockLabel;
    }

    /// <summary>
    /// Called by source-generated property setters to store values.
    /// Uses the base TerraformMap&lt;object&gt; indexer to store values in the _elements dictionary.
    /// </summary>
    /// <param name="terraformName">The Terraform property name (from [TerraformArgument("name")] attribute).</param>
    /// <param name="value">The value to store (TerraformValue&lt;T&gt;, TerraformList&lt;T&gt;, nested blocks, etc.).</param>
    public void SetPropertyValue(string terraformName, object? value)
    {
        if (value == null)
            return;

        // Handle TerraformExpression directly - avoid double-wrapping
        if (value is TerraformExpression expr)
        {
            this[terraformName] = TerraformValue.FromExpression<object>(expr);
        }
        // Handle TerraformValue<T> - unwrap and rewrap as TerraformValue<object> to avoid double-wrapping
        // When a TerraformValue<int> is passed as object, we can't use implicit conversion to TerraformValue<object>
        // because that would wrap the TerraformValue<int> instance itself as a literal object
        else if (value is ITerraformValue tfValue)
        {
            // ITerraformValue is ITerraformResolvable, so we can resolve and rewrap
            this[terraformName] = TerraformValue<object>.Lazy(ctx => tfValue.ResolveNodes(ctx));
        }
        // Handle ITerraformResolvable
        else if (value is ITerraformResolvable resolvable)
        {
            this[terraformName] = new TerraformValue<object>(resolvable);
        }
        else
        {
            // Use the indexer from base TerraformMap<object>
            // The indexer expects TerraformValue<object>, and there's an implicit conversion from object to TerraformValue<object>
            // So we can pass the value directly and it will be wrapped automatically
            this[terraformName] = value;
        }
    }

    /// <summary>
    /// Called by source-generated property getters to retrieve stored values.
    /// Returns null if the property was never set.
    /// Uses the base TerraformMap&lt;object&gt; indexer to retrieve values from the _elements dictionary.
    /// </summary>
    /// <typeparam name="T">The property type.</typeparam>
    /// <param name="terraformName">The Terraform property name.</param>
    /// <returns>The stored value or null.</returns>
    public T? GetPropertyValue<T>(string terraformName)
    {
        try
        {
            // Use the indexer from base TerraformMap<object>
            // The indexer returns a TerraformValue<object>
            var terraformValue = this[terraformName];

            // The TerraformValue<object> is just a wrapper around the actual value
            // We need to unwrap it to get the original value back
            // Since TerraformValue<T> doesn't expose its inner value directly,
            // and we stored the value as-is (which got wrapped), we can cast the wrapper itself
            return terraformValue is T directValue ? directValue : default;
        }
        catch (KeyNotFoundException)
        {
            return default;
        }
    }

    /// <summary>
    /// Called by source-generated property getters for required properties.
    /// Throws if the property was never set.
    /// </summary>
    /// <typeparam name="T">The property type.</typeparam>
    /// <param name="terraformName">The Terraform property name.</param>
    /// <returns>The stored value.</returns>
    /// <exception cref="InvalidOperationException">Thrown when a required property has not been set.</exception>
    protected T GetRequiredPropertyValue<T>(string terraformName)
    {
        return GetPropertyValue<T>(terraformName)
            ?? throw new InvalidOperationException($"Required property '{terraformName}' has not been set.");
    }

    /// <summary>
    /// Creates a reference expression to this block.
    /// Default implementation returns a simple identifier.
    /// Override in derived classes to provide specific reference formats (e.g., "resource.type.name").
    /// </summary>
    public virtual TerraformExpression AsReference()
        => TerraformExpression.Identifier(BlockLabel);

    /// <summary>
    /// Resolves this block to multiple syntax nodes (arguments + nested blocks).
    /// Nodes are sorted by the context's formatter.
    /// </summary>
    public override IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context)
    {
        var nodes = new List<TerraformSyntaxNode>();

        foreach (var (key, terraformValue) in _elements)
        {
            // Check if the resolvable inside is a dynamic block - special handling
            if (terraformValue.Resolvable is TerraformDynamicBlock<TerraformBlock> dynamicBlock)
            {
                // Dynamic blocks resolve to TerraformDynamicBlockExpression (a syntax node)
                var dynamicBlockExpr = dynamicBlock.Resolve(context);
                nodes.Add(dynamicBlockExpr);
            }
            // Check if the resolvable inside is a nested block
            else if (terraformValue.Resolvable is TerraformBlock nestedBlock)
            {
                var blockNode = new TerraformBlockNode(
                    nestedBlock.BlockLabel ?? key,
                    nestedBlock.ResolveNodes(context)
                );
                nodes.Add(blockNode);
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

        foreach (var node in formatted)
        {
            yield return node;
        }
    }
}
