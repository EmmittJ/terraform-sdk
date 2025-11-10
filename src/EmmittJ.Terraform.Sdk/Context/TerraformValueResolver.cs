using System.Collections;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Centralized logic for preparing and resolving any value type that can be stored in Terraform properties.
/// Handles: TerraformProperty, ITerraformResolvable, collections (List, HashSet, Dictionary), and plain values.
/// </summary>
/// <remarks>
/// This is the single source of truth for value resolution logic. Used by:
/// - TerraformBlock.Prepare() and Resolve()
/// - TerraformConstruct.Prepare() and WriteProperties()
/// - Any other container that stores heterogeneous property values
///
/// Example value types handled:
/// - TerraformProperty&lt;string&gt; → resolves to literal or expression
/// - List&lt;TerraformProperty&lt;string&gt;&gt; → resolves to Terraform list
/// - Dictionary&lt;string, TerraformProperty&lt;string&gt;&gt; → resolves to Terraform map
/// - TerraformBlock → resolves to nested object
/// - List&lt;TerraformBlock&gt; → resolves to list of nested objects
/// </remarks>
public static class TerraformValueResolver
{
    /// <summary>
    /// Prepares a value and all nested preparable values.
    /// Recursively traverses collections and dictionaries to prepare all nested items.
    /// </summary>
    /// <param name="value">The value to prepare (can be any type)</param>
    /// <param name="context">The context for dependency tracking</param>
    public static void PrepareValue(object? value, ITerraformContext context)
    {
        if (value == null)
        {
            return;
        }

        // Direct preparable
        if (value is ITerraformPreparable preparable)
        {
            preparable.Prepare(context);
            return;
        }

        // Collection of preparables - need to check the actual items
        if (value is IEnumerable enumerable and not string)
        {
            foreach (var item in enumerable)
            {
                PrepareValue(item, context);
            }
            return;
        }

        // Dictionary values
        if (value is IDictionary dictionary)
        {
            foreach (var item in dictionary.Values)
            {
                PrepareValue(item, context);
            }
        }
    }

    /// <summary>
    /// Resolves a value to a TerraformExpression.
    /// Pattern matching order is critical:
    /// 1. Check for TerraformExpression first (already resolved)
    /// 2. Check for TerraformProperty and ITerraformResolvable
    /// 3. Check for dictionaries BEFORE IEnumerable (Dictionary implements IEnumerable)
    /// 4. Check for typed collections (List&lt;TerraformProperty&gt;, List&lt;ITerraformResolvable&gt;)
    /// 5. Check for generic IEnumerable (fallback for any collection)
    /// 6. Fallback to literal value conversion
    /// </summary>
    /// <param name="value">The value to resolve</param>
    /// <param name="context">Optional context for resolution</param>
    /// <returns>A TerraformExpression representing the value</returns>
    public static TerraformExpression ResolveValue(object? value, ITerraformContext? context)
    {
        return value switch
        {
            // Null
            null => TerraformExpression.Raw("null"),

            // Already an expression
            TerraformExpression expr => expr,

            // Generic resolvable to expression
            ITerraformResolvable<TerraformExpression> resolvable => resolvable.Resolve(context),

            // Dictionary types (must check before IEnumerable since Dictionary implements it)
            IDictionary<string, ITerraformResolvable<TerraformExpression>> propDict => ResolvePropertyDictionary(propDict, context),
            IDictionary dict => ResolveDictionary(dict, context),

            // Collection types - must come after dictionary checks
            IEnumerable<ITerraformResolvable<TerraformExpression>> resolvableList => ResolveResolvableCollection(resolvableList, context),
            IEnumerable enumerable and not string => ResolveEnumerable(enumerable, context),

            // Fallback - literal value
            _ => TerraformExpression.FromObject(value)
        };
    }

    private static TerraformExpression ResolvePropertyCollection(
        IEnumerable<ITerraformResolvable<TerraformExpression>> properties,
        ITerraformContext? context)
    {
        var expressions = properties.Select(p => p.Resolve(context)).ToArray();
        return TerraformExpression.List(expressions);
    }

    private static TerraformExpression ResolveResolvableCollection(
        IEnumerable<ITerraformResolvable<TerraformExpression>> resolvables,
        ITerraformContext? context)
    {
        var expressions = resolvables.Select(r => r.Resolve(context)).ToArray();
        return TerraformExpression.List(expressions);
    }

    private static TerraformExpression ResolveEnumerable(
        IEnumerable enumerable,
        ITerraformContext? context)
    {
        var expressions = new List<TerraformExpression>();
        foreach (var item in enumerable)
        {
            expressions.Add(ResolveValue(item, context));
        }
        return TerraformExpression.List(expressions.ToArray());
    }

    private static TerraformExpression ResolvePropertyDictionary(
        IDictionary<string, ITerraformResolvable<TerraformExpression>> dictionary,
        ITerraformContext? context)
    {
        var map = new TerraformMapExpression();
        foreach (var (key, value) in dictionary)
        {
            map[key] = value.Resolve(context);
        }
        return map;
    }

    private static TerraformExpression ResolveDictionary(
        IDictionary dictionary,
        ITerraformContext? context)
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
