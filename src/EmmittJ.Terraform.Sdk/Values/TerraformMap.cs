using System.Collections;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform map attribute with string keys and typed values.
/// Terraform maps are key-value collections where keys must be strings.
/// Inherits from TerraformValue&lt;IDictionary&lt;string, T&gt;&gt; for clean typing.
/// </summary>
/// <typeparam name="T">The value type (string, double, bool, TerraformBlock&lt;T&gt;, etc.)</typeparam>
public class TerraformMap<T> : TerraformValue<IDictionary<string, T>>, IEnumerable
{
    // Protected: Store values as TerraformValue<T> to preserve unknowns
    // Protected to allow derived classes like TerraformBlock to access elements
    protected readonly Dictionary<string, TerraformValue<T>> _elements;

    // Parameterless constructor for collection initializer syntax
    public TerraformMap()
        : base()
    {
        _elements = new Dictionary<string, TerraformValue<T>>();
    }

    // Constructor for literal values
    public TerraformMap(IDictionary<string, T> values)
        : this()
    {
        if (values != null)
        {
            foreach (var kvp in values)
            {
                _elements[kvp.Key] = kvp.Value;
            }
        }
    }

    // Constructor for mixed TerraformValue<T> values
    public TerraformMap(IDictionary<string, TerraformValue<T>> values)
        : this()
    {
        if (values != null)
        {
            foreach (var kvp in values)
            {
                _elements[kvp.Key] = kvp.Value;
            }
        }
    }

    // Constructor for expressions/references
    protected TerraformMap(ITerraformResolvable resolvable)
        : base(resolvable)
    {
        _elements = new Dictionary<string, TerraformValue<T>>();
    }

    /// <summary>
    /// Override resolution to handle nested TerraformValue&lt;T&gt; values.
    /// Maps resolve to a single MapExpression node.
    /// </summary>
    public override IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context)
    {
        var resolvedPairs = new List<KeyValuePair<string, TerraformSyntaxNode>>();

        foreach (var kvp in _elements)
        {
            // Resolve the value - take first node as expression
            var nodes = kvp.Value.ResolveNodes(context).ToList();
            var expr = nodes.Count > 1 ? TerraformExpression.List(nodes) : nodes.FirstOrDefault();
            if (expr is null)
            {
                continue;
            }
            resolvedPairs.Add(new KeyValuePair<string, TerraformSyntaxNode>(kvp.Key, expr));
        }

        yield return TerraformExpression.Map(resolvedPairs);
    }

    // Indexer for collection initializer syntax { ["key"] = value }
    public TerraformValue<T> this[string key]
    {
        get => _elements.TryGetValue(key, out var value) ? value : throw new KeyNotFoundException($"Key '{key}' not found in map");
        set => _elements[key] = value;
    }

    // Add method for collection initializer syntax { key, value }
    public void Add(string key, T value)
    {
        _elements[key] = value;
    }

    // Add method for adding TerraformValue<T> directly
    public void Add(string key, TerraformValue<T> value)
    {
        _elements[key] = value;
    }

    // Implicit conversion from Dictionary
    public static implicit operator TerraformMap<T>(Dictionary<string, T> value)
        => new TerraformMap<T>(value);

    // Accept mixed TerraformValue<T> values
    public static implicit operator TerraformMap<T>(Dictionary<string, TerraformValue<T>> values)
        => new TerraformMap<T>(values);

    // Implicit conversion from ITerraformResolvable (like TerraformExpression)
    public static implicit operator TerraformMap<T>(TerraformExpression expression)
        => new TerraformMap<T>(expression);

    /// <summary>
    /// Creates a lazy TerraformMap that will be resolved at resolution time.
    /// The producer function is called during resolution to generate the final expression.
    /// </summary>
    /// <param name="producer">A function that produces a TerraformSyntaxNode when called with a resolution context.</param>
    /// <returns>A TerraformMap that wraps the lazy producer.</returns>
    public static new TerraformMap<T> Lazy(Func<ITerraformContext, IEnumerable<TerraformSyntaxNode>> producer)
        => new TerraformLazyMap<T>(producer);

    // IEnumerable for collection initializer syntax (non-functional)
    IEnumerator IEnumerable.GetEnumerator()
        => throw new NotSupportedException(
            "TerraformMap cannot be enumerated synchronously. " +
            "Values are resolved during Terraform synthesis.");

    // Static empty map
    public static TerraformMap<T> Empty
        => new TerraformMap<T>();
}

/// <summary>
/// Internal lazy map implementation for deferred resolution.
/// </summary>
internal sealed class TerraformLazyMap<T> : TerraformMap<T>
{
    private readonly Func<ITerraformContext, IEnumerable<TerraformSyntaxNode>> _producer;

    public TerraformLazyMap(Func<ITerraformContext, IEnumerable<TerraformSyntaxNode>> producer)
        : base()
    {
        _producer = producer ?? throw new ArgumentNullException(nameof(producer));
    }

    public override IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context)
    {
        return _producer(context);
    }
}
