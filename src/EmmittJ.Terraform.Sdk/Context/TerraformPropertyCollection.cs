using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Shared property storage for constructs and configuration containers.
/// Stores heterogeneous values: TerraformProperty, ITerraformResolvable, collections, and plain values.
/// Maintains ordering semantics via optional priority.
/// </summary>
internal sealed class TerraformPropertyCollection
{
    private readonly Dictionary<string, object?> _properties = new();
    private readonly Dictionary<string, int?> _priorities = new();

    public int Count => _properties.Count;

    public IEnumerable<string> Keys => _properties.Keys;

    public IEnumerable<object?> GetValues() => _properties.Values;

    public bool ContainsKey(string key) => _properties.ContainsKey(key);

    /// <summary>
    /// Sets or removes a property value with optional priority.
    /// Supports any value type: TerraformProperty, collections, blocks, literals.
    /// </summary>
    public void Set(string key, object? value, int? priority = null)
    {
        if (value == null)
        {
            _properties.Remove(key);
            _priorities.Remove(key);
            return;
        }

        _properties[key] = value;
        _priorities[key] = priority;
    }

    /// <summary>
    /// Gets a property value as a specific type.
    /// </summary>
    public T? Get<T>(string key) where T : class
    {
        return _properties.TryGetValue(key, out var value) && value is T typedValue
            ? typedValue
            : null;
    }

    /// <summary>
    /// Gets a required property value as a specific type.
    /// Throws if the property is null.
    /// </summary>
    /// <exception cref="InvalidOperationException">Thrown when the property value is null.</exception>
    public T GetRequired<T>(string key) where T : class
        => Get<T>(key) ?? throw new InvalidOperationException($"Required property '{key}' is null.");

    /// <summary>
    /// Enumerates properties sorted by priority then key.
    /// Returns (key, value) pairs where value can be any object type.
    /// </summary>
    public IEnumerable<KeyValuePair<string, object?>> GetOrderedProperties()
    {
        return _properties
            .OrderBy(kvp => _priorities.TryGetValue(kvp.Key, out var priority) ? priority ?? int.MaxValue : int.MaxValue)
            .ThenBy(kvp => kvp.Key);
    }
}
