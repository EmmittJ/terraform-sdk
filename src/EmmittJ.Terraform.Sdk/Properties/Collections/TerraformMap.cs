using System.Collections;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform map property. Stores key-value pairs and provides reference semantics.
/// Implements IDictionary for natural C# dictionary usage.
/// </summary>
/// <typeparam name="TValue">The type of values stored in the map.</typeparam>
/// <remarks>
/// Note on Indexer Behavior:
/// - Getter creates a NEW TerraformReferenceProperty instance on each access
/// - This represents the Terraform expression: map["key"]
/// - For caching reference instances, store the result in a variable
///
/// Example:
/// <code>
/// var tags = instance.Tags;  // TerraformMap&lt;string&gt;
/// var nameTag = tags["Name"];  // TerraformReferenceProperty - represents instance.tags["Name"]
///
/// // Cache if used multiple times
/// var nameRef = instance.Tags["Name"];
/// volume.Tags["InstanceName"] = nameRef;
/// </code>
/// </remarks>
public class TerraformMap<TValue> : TerraformProperty<IDictionary<string, TerraformProperty<TValue>>>,
    IDictionary<string, TerraformProperty<TValue>>,
    ITerraformCollection<TerraformProperty<TValue>>,
    ITerraformCollection
{
    private readonly Dictionary<string, TerraformProperty<TValue>> _items = new();

    /// <summary>
    /// Initializes a new Terraform map property.
    /// </summary>
    /// <param name="resourceAddress">The address of the resource.</param>
    /// <param name="attributeName">The name of the attribute.</param>
    public TerraformMap(string resourceAddress, string attributeName)
        : base(resourceAddress, attributeName)
    {
    }

    /// <summary>
    /// Gets or sets the element with the specified key.
    /// </summary>
    /// <param name="key">The key of the element.</param>
    /// <returns>
    /// Getter: A NEW TerraformReferenceProperty instance representing the keyed element reference.
    /// Note: Creates a new instance on each access - cache if used frequently.
    /// </returns>
    /// <remarks>
    /// The getter returns a reference to the keyed property (e.g., instance.tags["Name"]),
    /// NOT the actual value. This matches Terraform's reference semantics.
    /// </remarks>
    public TerraformProperty<TValue> this[string key]
    {
        get => new TerraformReferenceProperty<TValue, IDictionary<string, TerraformProperty<TValue>>, string>(
            this,
            new TerraformLiteralProperty<string>("", "") { Value = key }
        );
        set => _items[key] = value;
    }

    public ICollection<string> Keys => _items.Keys;
    public ICollection<TerraformProperty<TValue>> Values => _items.Values;
    public int Count => _items.Count;
    public bool IsReadOnly => false;

    public void Add(string key, TerraformProperty<TValue> value) => _items.Add(key, value);
    public void Add(KeyValuePair<string, TerraformProperty<TValue>> item) => _items.Add(item.Key, item.Value);
    public void Clear() => _items.Clear();
    public bool Contains(KeyValuePair<string, TerraformProperty<TValue>> item) => _items.Contains(item);
    public bool ContainsKey(string key) => _items.ContainsKey(key);
    public void CopyTo(KeyValuePair<string, TerraformProperty<TValue>>[] array, int arrayIndex) =>
        ((IDictionary<string, TerraformProperty<TValue>>)_items).CopyTo(array, arrayIndex);
    public IEnumerator<KeyValuePair<string, TerraformProperty<TValue>>> GetEnumerator() => _items.GetEnumerator();
    public bool Remove(string key) => _items.Remove(key);
    public bool Remove(KeyValuePair<string, TerraformProperty<TValue>> item) =>
        ((IDictionary<string, TerraformProperty<TValue>>)_items).Remove(item);
    public bool TryGetValue(string key, out TerraformProperty<TValue> value) => _items.TryGetValue(key, out value!);
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    /// <summary>
    /// Preparation phase - prepares all nested preparable values.
    /// </summary>
    /// <param name="context">The context for dependency tracking.</param>
    public override void Prepare(ITerraformContext context)
    {
        foreach (var (_, value) in _items)
        {
            if (value is ITerraformPreparable preparable)
            {
                preparable.Prepare(context);
            }
        }
    }

    /// <summary>
    /// Resolution phase - resolves to a Terraform map expression.
    /// </summary>
    /// <param name="context">Optional context for resolution.</param>
    /// <returns>A Terraform map expression containing all resolved key-value pairs.</returns>
    public override TerraformExpression Resolve(ITerraformContext? context = null)
    {
        var mapExpr = TerraformExpression.Object();

        foreach (var (key, value) in _items)
        {
            mapExpr[key] = value.Resolve(context);
        }

        return mapExpr;
    }

    /// <summary>
    /// Implicit conversion from Dictionary&lt;string, TerraformProperty&lt;TValue&gt;&gt;.
    /// Enables ergonomic dictionary initialization.
    /// </summary>
    /// <param name="values">The dictionary to wrap.</param>
    public static implicit operator TerraformMap<TValue>(Dictionary<string, TerraformProperty<TValue>> values)
    {
        var map = new TerraformMap<TValue>("", "");
        foreach (var (key, value) in values)
        {
            map.Add(key, value);
        }
        return map;
    }
}
