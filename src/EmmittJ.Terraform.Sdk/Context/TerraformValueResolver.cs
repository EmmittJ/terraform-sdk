using System.Collections;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Centralized logic for resolving any value type that can be stored in Terraform properties.
/// Handles: TerraformValue&lt;T&gt;, ITerraformResolvable, collections (List, HashSet, Dictionary), and plain values.
/// </summary>
/// <remarks>
/// This is the single source of truth for value resolution logic. Used by:
/// - TerraformBlock.ResolveNodes()
/// - Any other container that stores heterogeneous property values
///
/// Example value types handled:
/// - TerraformValue&lt;string&gt; → resolves to literal or expression
/// - List&lt;TerraformValue&lt;string&gt;&gt; → resolves to Terraform list
/// - Dictionary&lt;string, TerraformValue&lt;string&gt;&gt; → resolves to Terraform map
/// - ITerraformSerializable → resolves to nested object
/// - List&lt;ITerraformSerializable&gt; → resolves to list of nested objects
/// </remarks>
public static class TerraformValueResolver
{
    /// <summary>
    /// Resolves a value to a TerraformExpression.
    /// Pattern matching order is critical:
    /// 1. Check for TerraformExpression first (already resolved)
    /// 2. Check for ITerraformValue (TerraformValue&lt;T&gt;)
    /// 3. Check for ITerraformResolvable
    /// 4. Check for dictionaries BEFORE IEnumerable (Dictionary implements IEnumerable)
    /// 5. Check for typed collections (List&lt;ITerraformResolvable&gt;)
    /// 6. Check for generic IEnumerable (fallback for any collection)
    /// 7. Fallback to literal value conversion
    /// </summary>
    /// <param name="value">The value to resolve</param>
    /// <param name="context">Optional context for resolution</param>
    /// <returns>A TerraformExpression representing the value</returns>
    public static TerraformExpression ResolveValue(object? value, ITerraformContext? context)
    {
        context ??= TerraformContext.Temporary();

        return value switch
        {
            // Null
            null => TerraformExpression.Raw("null"),

            // Already an expression
            TerraformExpression expr => expr,

            // TerraformValue<T> - use interface instead of reflection
            ITerraformValue terraformValue => ResolveTerraformValue(terraformValue, context),

            // Generic resolvable to expression
            ITerraformResolvable resolvable => ResolveResolvableValue(resolvable, context),

            // Dictionary types (must check before IEnumerable since Dictionary implements it)
            IDictionary dict => ResolveDictionary(dict, context),

            // Collection types - must come after dictionary checks
            IEnumerable enumerable and not string => ResolveEnumerable(enumerable, context),

            // Fallback - literal value
            _ => TerraformExpression.FromObject(value)
        };
    }

    /// <summary>
    /// Resolves an ITerraformResolvable to a TerraformExpression.
    /// </summary>
    private static TerraformExpression ResolveResolvableValue(ITerraformResolvable resolvable, ITerraformContext context)
    {
        var nodes = resolvable.ResolveNodes(context).ToList();
        if (nodes.Count == 1 && nodes[0] is TerraformExpression expr)
        {
            return expr;
        }
        throw new InvalidOperationException($"Resolvable resolved to {nodes.Count} nodes instead of single expression");
    }

    /// <summary>
    /// Resolves a TerraformValue&lt;T&gt; using its ResolveNodes method via interface.
    /// </summary>
    private static TerraformExpression ResolveTerraformValue(ITerraformValue terraformValue, ITerraformContext context)
    {
        var nodes = terraformValue.ResolveNodes(context).ToList();
        if (nodes.Count == 1 && nodes[0] is TerraformExpression expr)
        {
            return expr;
        }
        throw new InvalidOperationException($"TerraformValue resolved to {nodes.Count} nodes instead of single expression");
    }

    private static TerraformExpression ResolveEnumerable(IEnumerable enumerable, ITerraformContext context)
    {
        var expressions = new List<TerraformExpression>();
        foreach (var item in enumerable)
        {
            expressions.Add(ResolveValue(item, context));
        }
        return TerraformExpression.List(expressions.ToArray());
    }

    private static TerraformExpression ResolveDictionary(IDictionary dictionary, ITerraformContext context)
    {
        var map = new TerraformMapExpression();
        foreach (DictionaryEntry entry in dictionary)
        {
            var key = entry.Key.ToString() ?? throw new InvalidOperationException($"Dictionary key cannot be null");
            map[key] = ResolveValue(entry.Value, context);
        }
        return map;
    }
}
