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
    /// Copy constructor for creating a copy of an existing map.
    /// Used by <see cref="WithLineage"/> to create copies with lineage attached.
    /// </summary>
    /// <param name="other">The map to copy.</param>
    /// <param name="isCopy">Marker to disambiguate from other constructors.</param>
    protected TerraformMap(TerraformMap<T> other, bool isCopy)
        : base()
    {
        _ = isCopy; // Marker parameter for disambiguation
        _elements = new Dictionary<string, TerraformValue<T>>(other._elements);
    }

    /// <summary>
    /// Creates a copy of this map with the specified lineage attached.
    /// </summary>
    /// <param name="lineage">The lineage to attach to the copy.</param>
    /// <returns>A new <see cref="TerraformMap{T}"/> with the specified lineage.</returns>
    public override TerraformValue<IDictionary<string, T>> WithLineage(TerraformLineage? lineage)
    {
        var copy = new TerraformMap<T>(this, isCopy: true);
        copy.Lineage = lineage;
        return copy;
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
        get
        {
            if (!_elements.TryGetValue(key, out var value))
            {
                throw new KeyNotFoundException($"Key '{key}' not found in map");
            }

            // If this map has lineage, extend it and attach to the value
            if (Lineage is not null)
            {
                return value.WithLineage(Lineage.WithMember(key));
            }

            return value;
        }
        set => SetArgument(key, value);
    }

    /// <summary>
    /// Sets an argument value with proper handling of ITerraformValue types to avoid double-wrapping.
    /// Used by indexer and derived classes like TerraformBlock.
    /// </summary>
    /// <param name="key">The key name.</param>
    /// <param name="value">The value to store (TerraformValue&lt;T&gt;, TerraformExpression, TerraformList&lt;T&gt;, etc.).</param>
    public void SetArgument(string key, object? value)
    {
        if (value is null)
        {
            _elements.Remove(key);
            return;
        }

        _elements[key] = TerraformValue<T>.ConvertFrom(value);
    }

    /// <summary>
    /// Called by source-generated property getters to retrieve stored values.
    /// Returns null if the property was never set.
    /// Returns a copy with lineage attached if this map has lineage.
    /// For blocks, sets lineage directly (blocks resolve their own content, lineage is for references).
    /// </summary>
    /// <typeparam name="TValue">The property type.</typeparam>
    /// <param name="terraformName">The Terraform property name.</param>
    /// <returns>A copy of the stored value with lineage attached, or null.</returns>
    public TValue? GetArgument<TValue>(string terraformName)
    {
        if (!_elements.TryGetValue(terraformName, out var value))
        {
            return default;
        }

        // Check if this is a lazy value with preserved identity
        TValue? result;
        if (value is TerraformLazyValue<T> lazy && lazy.Original is TValue unwrapped)
        {
            result = unwrapped;
        }
        else
        {
            result = value is TValue directValue ? directValue : default;
        }

        // Attach lineage if this map has lineage
        if (result is ITerraformValue terraformValue && Lineage is not null)
        {
            var lineageForMember = Lineage.WithMember(terraformName);

            // For blocks, set lineage directly (blocks resolve their own content, lineage is for reference building)
            // For other values, return a COPY with lineage to preserve original for source rendering
            if (result is TerraformBlock block)
            {
                block.Lineage = lineageForMember;
                return result;
            }

            return (TValue)terraformValue.WithLineage(lineageForMember);
        }

        return result;
    }

    /// <summary>
    /// Called by source-generated property getters for required properties.
    /// Throws if the property was never set.
    /// </summary>
    /// <typeparam name="TValue">The property type.</typeparam>
    /// <param name="terraformName">The Terraform property name.</param>
    /// <returns>The stored value.</returns>
    /// <exception cref="InvalidOperationException">Thrown when a required property has not been set.</exception>
    public TValue GetRequiredArgument<TValue>(string terraformName)
    {
        return GetArgument<TValue>(terraformName)
            ?? throw new InvalidOperationException(
                $"Required property '{terraformName}' has not been set on {GetType().Name}. " +
                $"Set this property using block[\"{terraformName}\"] = value before calling ToHcl().");
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

    /// <summary>
    /// Converts this TerraformMap to a lazy TerraformMap of a different type.
    /// This is useful when the underlying value is known to be of a different type
    /// but needs to be treated as such in certain contexts (e.g., casting from string to a more specific type).
    /// /// </summary>
    public new TerraformMap<TLazy> AsLazy<TLazy>()
        => TerraformMap<TLazy>.Lazy(ResolveNodes);
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

    /// <summary>
    /// Copy constructor for creating a copy with lineage.
    /// </summary>
    /// <param name="other">The map to copy.</param>
    /// <param name="isCopy">Marker to disambiguate from other constructors.</param>
    private TerraformLazyMap(TerraformLazyMap<T> other, bool isCopy)
        : base()
    {
        _ = isCopy; // Marker parameter for disambiguation
        _producer = other._producer;
    }

    public override IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context)
    {
        // Check lineage first - if present, resolve to reference
        if (Lineage is not null)
        {
            return [Lineage.BuildExpression()];
        }

        return _producer(context);
    }

    /// <summary>
    /// Creates a copy of this lazy map with the specified lineage attached.
    /// </summary>
    public override TerraformValue<IDictionary<string, T>> WithLineage(TerraformLineage? lineage)
    {
        var copy = new TerraformLazyMap<T>(this, isCopy: true);
        copy.Lineage = lineage;
        return copy;
    }
}
