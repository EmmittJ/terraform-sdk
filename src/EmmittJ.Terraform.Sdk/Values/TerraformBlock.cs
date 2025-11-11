namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform nested block as a specialized map of properties.
/// Blocks are maps where keys are property names and values are heterogeneous types.
///
/// Uses ITerraformBlockStorage interface to access property values without reflection.
/// Block classes should implement this interface to provide their property dictionary.
/// </summary>
/// <typeparam name="T">The block class type (e.g., AzurermContainerAppTemplateBlock)</typeparam>
public class TerraformBlock<T> : TerraformMap<object> where T : class
{
    private readonly T? _block;

    public TerraformBlock(T? block)
        : base(CreateMapFromBlock(block))
    {
        _block = block;
    }

    /// <summary>
    /// Gets the underlying block instance for direct property access.
    /// </summary>
    public T? Value => _block;

    /// <summary>
    /// Convert block's properties to a map for resolution.
    /// Uses ITerraformBlockStorage interface if available, otherwise returns empty map.
    /// </summary>
    private static Dictionary<string, object> CreateMapFromBlock(T? block)
    {
        if (block == null)
            return new Dictionary<string, object>();

        // If the block implements ITerraformBlockStorage, use its property values
        if (block is ITerraformBlockStorage storage)
        {
            var map = new Dictionary<string, object>();
            foreach (var (key, value) in storage.GetPropertyValues())
            {
                if (value != null)
                {
                    map[key] = value;
                }
            }
            return map;
        }

        // Fallback: empty map
        return new Dictionary<string, object>();
    }

    /// <summary>
    /// Override resolution to handle nested TerraformValue&lt;T&gt; properties correctly.
    /// Uses ITerraformBlockStorage interface to get property values without reflection.
    /// </summary>
    public override TerraformExpression Resolve(ITerraformResolveContext context)
    {
        if (_block == null)
            return TerraformExpression.Map(); // Empty block

        // If the block implements ITerraformBlockStorage, use it
        if (_block is ITerraformBlockStorage storage)
        {
            var resolvedPairs = new List<KeyValuePair<string, TerraformExpression>>();

            foreach (var (terraformName, value) in storage.GetPropertyValues())
            {
                if (value == null)
                    continue;

                // Handle ITerraformValue (TerraformValue<T>) via interface
                TerraformExpression resolvedValue;
                if (value is ITerraformValue terraformValue)
                {
                    if (!terraformValue.HasValue)
                        continue;
                    resolvedValue = terraformValue.Resolve(context);
                }
                // Handle other resolvables
                else if (value is ITerraformResolvable resolvable)
                {
                    resolvedValue = resolvable.Resolve(context);
                }
                else
                {
                    resolvedValue = TerraformExpression.Literal(value);
                }

                resolvedPairs.Add(new KeyValuePair<string, TerraformExpression>(
                    terraformName,
                    resolvedValue
                ));
            }

            return TerraformExpression.Map(resolvedPairs);
        }

        // Fallback: empty block
        return TerraformExpression.Map();
    }

    // Implicit conversion from block instance
    public static implicit operator TerraformBlock<T>?(T? block)
        => block != null ? new TerraformBlock<T>(block) : null;

    // Allow accessing the block directly
    public static implicit operator T?(TerraformBlock<T> wrapper)
        => wrapper._block;
}
