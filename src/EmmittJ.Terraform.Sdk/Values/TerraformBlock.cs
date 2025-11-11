using System.Reflection;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform nested block as a specialized map of properties.
/// Blocks are maps where keys are property names and values are heterogeneous types.
/// Inherits from TerraformMap&lt;object&gt; to reuse map resolution infrastructure.
///
/// KEY INSIGHT: Terraform blocks are semantically maps with string keys (property names)
/// and heterogeneous values (different types per property). This design leverages the
/// map infrastructure while maintaining type safety via the generic POCO wrapper.
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
    /// Uses reflection to extract property values.
    /// </summary>
    private static Dictionary<string, object> CreateMapFromBlock(T? block)
    {
        if (block == null)
            return new Dictionary<string, object>();

        var map = new Dictionary<string, object>();
        var properties = typeof(T).GetProperties();

        foreach (var prop in properties)
        {
            var attr = prop.GetCustomAttribute<TerraformPropertyNameAttribute>();
            if (attr != null)
            {
                var value = prop.GetValue(block);
                if (value != null)
                {
                    map[attr.Name] = value;
                }
            }
        }

        return map;
    }

    /// <summary>
    /// Override resolution to handle nested TerraformValue&lt;T&gt; properties correctly.
    /// This extracts properties via reflection and resolves each to a TerraformExpression.
    /// </summary>
    public override TerraformExpression Resolve(ITerraformResolveContext context)
    {
        if (_block == null)
            return TerraformExpression.Map(); // Empty block

        // Resolve each property individually
        var resolvedPairs = new List<KeyValuePair<string, TerraformExpression>>();
        var properties = typeof(T).GetProperties();

        foreach (var prop in properties)
        {
            var attr = prop.GetCustomAttribute<TerraformPropertyNameAttribute>();
            if (attr == null)
                continue;

            var value = prop.GetValue(_block);
            if (value == null)
                continue;

            // Handle TerraformValue<T>, TerraformList<T>, etc. via resolution
            TerraformExpression resolvedValue;
            if (value is ITerraformResolvable resolvable)
            {
                resolvedValue = resolvable.Resolve(context);
            }
            else if (value.GetType().IsGenericType)
            {
                // Try to resolve via reflection (for TerraformValue<T>, etc.)
                var resolveMethod = value.GetType().GetMethod("Resolve");
                if (resolveMethod != null)
                {
                    resolvedValue = (TerraformExpression)resolveMethod.Invoke(value, new object[] { context })!;
                }
                else
                {
                    resolvedValue = TerraformExpression.Literal(value);
                }
            }
            else
            {
                resolvedValue = TerraformExpression.Literal(value);
            }

            resolvedPairs.Add(new KeyValuePair<string, TerraformExpression>(
                attr.Name,
                resolvedValue
            ));
        }

        return TerraformExpression.Map(resolvedPairs);
    }

    // Implicit conversion from block instance
    public static implicit operator TerraformBlock<T>?(T? block)
        => block != null ? new TerraformBlock<T>(block) : null;

    // Allow accessing the block directly
    public static implicit operator T?(TerraformBlock<T> wrapper)
        => wrapper._block;
}
