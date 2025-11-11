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
    // Internal: Store values as TerraformValue<T> to preserve unknowns
    private readonly Dictionary<string, TerraformValue<T>> _elements;

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
    /// </summary>
    public override TerraformExpression Resolve(ITerraformResolveContext context)
    {
        var resolvedPairs = _elements.Select(kvp =>
            new KeyValuePair<string, TerraformExpression>(
                kvp.Key,
                kvp.Value.Resolve(context)
            ));

        return TerraformExpression.Map(resolvedPairs);
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

    // Implicit conversion from TerraformExpression
    public static implicit operator TerraformMap<T>(TerraformExpression expression)
        => new TerraformMap<T>(expression);

    // Implicit conversion from TerraformReference
    public static implicit operator TerraformMap<T>(TerraformReference reference)
        => new TerraformMap<T>(reference);

    // IEnumerable for collection initializer syntax (non-functional)
    IEnumerator IEnumerable.GetEnumerator()
        => throw new NotSupportedException(
            "TerraformMap cannot be enumerated synchronously. " +
            "Values are resolved during Terraform synthesis.");

    // Static empty map
    public static TerraformMap<T> Empty
        => new TerraformMap<T>();
}
