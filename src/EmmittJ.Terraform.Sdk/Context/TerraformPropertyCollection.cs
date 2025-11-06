using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Shared property storage for constructs and configuration containers.
/// Maintains ordering semantics via optional priority and exposes read-only dictionary access.
/// </summary>
internal sealed class TerraformPropertyCollection : IReadOnlyDictionary<string, TerraformProperty>
{
    private readonly Dictionary<string, TerraformProperty> _properties = new();

    public int Count => _properties.Count;

    public IEnumerable<string> Keys => _properties.Keys;

    public IEnumerable<TerraformProperty> Values => _properties.Values;

    public TerraformProperty this[string key] => _properties[key];

    public bool ContainsKey(string key) => _properties.ContainsKey(key);

    public bool TryGetValue(string key, out TerraformProperty value)
    {
        var result = _properties.TryGetValue(key, out var foundValue);
        value = foundValue!;
        return result;
    }

    public IEnumerator<KeyValuePair<string, TerraformProperty>> GetEnumerator() => _properties.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    /// <summary>
    /// Sets or removes a property while applying the desired priority.
    /// </summary>
    public void Set(string key, TerraformProperty? value, int? priority = null)
    {
        if (value == null)
        {
            _properties.Remove(key);
            return;
        }

        value.Priority = priority;
        _properties[key] = value;
    }

    /// <summary>
    /// Gets a property as a specific type.
    /// </summary>
    public T? Get<T>(string key) where T : class
    {
        return _properties.TryGetValue(key, out var value) && value is T typedValue
            ? typedValue
            : null;
    }

    /// <summary>
    /// Enumerates properties sorted by priority then key.
    /// </summary>
    public IEnumerable<KeyValuePair<string, TerraformProperty>> GetOrderedProperties()
        => _properties
            .OrderBy(kvp => kvp.Value.Priority ?? int.MaxValue)
            .ThenBy(kvp => kvp.Key);
}
