namespace EmmittJ.Terraform.Sdk;

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

/// <summary>
/// Represents a Terraform object/map with string keys and expression values.
/// Provides an ergonomic API for building HCL objects without TerraformExpression.Raw.
/// Similar to BicepDictionary in Azure.Provisioning.
/// Supports collection initializer syntax and standard dictionary interfaces.
/// </summary>
public class TerraformObjectExpression : TerraformExpression,
    IDictionary<string, TerraformExpression>,
    IDictionary,
    IReadOnlyDictionary<string, TerraformExpression>
{
    protected readonly Dictionary<string, TerraformExpression> _properties = new();

    /// <summary>
    /// Creates a new empty TerraformObject.
    /// </summary>
    public TerraformObjectExpression() { }

    #region IDictionary<string, TerraformExpression> Implementation

    /// <summary>
    /// Adds a property with a TerraformExpression value (for collection initializer syntax).
    /// </summary>
    public void Add(string key, TerraformExpression value)
    {
        _properties[key] = value ?? throw new ArgumentNullException(nameof(value));
    }

    /// <summary>
    /// Adds a property with a literal value (for collection initializer syntax).
    /// </summary>
    public void Add<T>(string key, T value)
    {
        // Redirect to expression overload if this is a TerraformExpression
        if (value is TerraformExpression expr)
        {
            Add(key, expr);
            return;
        }

        _properties[key] = Literal(value);
    }

    /// <summary>
    /// Indexer to get/set properties.
    /// </summary>
    public override TerraformExpression this[string key]
    {
        get => _properties[key];
        set => _properties[key] = value;
    }

    /// <summary>
    /// Removes a property.
    /// </summary>
    public bool Remove(string key) => _properties.Remove(key);

    /// <summary>
    /// Checks if a property exists.
    /// </summary>
    public bool ContainsKey(string key) => _properties.ContainsKey(key);

    /// <summary>
    /// Tries to get a property value.
    /// </summary>
    public bool TryGetValue(string key, [MaybeNullWhen(false)] out TerraformExpression value)
        => _properties.TryGetValue(key, out value);

    /// <summary>
    /// Gets the keys in the dictionary.
    /// </summary>
    public ICollection<string> Keys => _properties.Keys;

    /// <summary>
    /// Gets the values in the dictionary.
    /// </summary>
    public ICollection<TerraformExpression> Values => _properties.Values;

    /// <summary>
    /// Gets the number of properties.
    /// </summary>
    public int Count => _properties.Count;

    /// <summary>
    /// Gets whether the dictionary is read-only (always false).
    /// </summary>
    public bool IsReadOnly => false;

    /// <summary>
    /// Clears all properties.
    /// </summary>
    public void Clear() => _properties.Clear();

    /// <summary>
    /// Adds a key-value pair.
    /// </summary>
    void ICollection<KeyValuePair<string, TerraformExpression>>.Add(KeyValuePair<string, TerraformExpression> item)
        => Add(item.Key, item.Value);

    /// <summary>
    /// Checks if the dictionary contains a key-value pair.
    /// </summary>
    bool ICollection<KeyValuePair<string, TerraformExpression>>.Contains(KeyValuePair<string, TerraformExpression> item)
        => ((ICollection<KeyValuePair<string, TerraformExpression>>)_properties).Contains(item);

    /// <summary>
    /// Copies the dictionary to an array.
    /// </summary>
    void ICollection<KeyValuePair<string, TerraformExpression>>.CopyTo(KeyValuePair<string, TerraformExpression>[] array, int arrayIndex)
        => ((ICollection<KeyValuePair<string, TerraformExpression>>)_properties).CopyTo(array, arrayIndex);

    /// <summary>
    /// Removes a key-value pair.
    /// </summary>
    bool ICollection<KeyValuePair<string, TerraformExpression>>.Remove(KeyValuePair<string, TerraformExpression> item)
        => ((ICollection<KeyValuePair<string, TerraformExpression>>)_properties).Remove(item);

    /// <summary>
    /// Gets the enumerator for the properties.
    /// </summary>
    public IEnumerator<KeyValuePair<string, TerraformExpression>> GetEnumerator()
        => _properties.GetEnumerator();

    /// <summary>
    /// Gets the enumerator for the properties (non-generic).
    /// </summary>
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    #endregion

    #region IReadOnlyDictionary<string, TerraformExpression> Implementation

    IEnumerable<string> IReadOnlyDictionary<string, TerraformExpression>.Keys => _properties.Keys;
    IEnumerable<TerraformExpression> IReadOnlyDictionary<string, TerraformExpression>.Values => _properties.Values;

    #endregion

    #region IDictionary (Non-Generic) Implementation

    bool IDictionary.IsFixedSize => false;
    bool IDictionary.IsReadOnly => false;
    ICollection IDictionary.Keys => _properties.Keys;
    ICollection IDictionary.Values => _properties.Values;
    bool ICollection.IsSynchronized => false;
    object ICollection.SyncRoot => ((ICollection)_properties).SyncRoot;

    object? IDictionary.this[object key]
    {
        get => key is string s ? _properties[s] : null;
        set
        {
            if (key is not string s)
                throw new ArgumentException("Key must be a string", nameof(key));
            if (value is null)
                throw new ArgumentNullException(nameof(value));

            var expr = value as TerraformExpression ?? TerraformExpression.FromObject(value);
            _properties[s] = expr;
        }
    }

    void IDictionary.Add(object key, object? value)
    {
        if (key is not string s)
            throw new ArgumentException("Key must be a string", nameof(key));
        if (value is null)
            throw new ArgumentNullException(nameof(value));

        var expr = value as TerraformExpression ?? TerraformExpression.FromObject(value);
        Add(s, expr);
    }

    bool IDictionary.Contains(object key) => key is string s && ContainsKey(s);

    IDictionaryEnumerator IDictionary.GetEnumerator() => ((IDictionary)_properties).GetEnumerator();

    void IDictionary.Remove(object key)
    {
        if (key is string s)
            Remove(s);
    }

    void ICollection.CopyTo(Array array, int index) => ((ICollection)_properties).CopyTo(array, index);

    #endregion

    #region Helper Methods

    /// <summary>
    /// Gets a property value (returns null if not found).
    /// </summary>
    public TerraformExpression? Get(string key)
    {
        return _properties.TryGetValue(key, out var value) ? value : null;
    }

    /// <summary>
    /// Merges another TerraformObject into this one.
    /// Later values overwrite earlier ones.
    /// </summary>
    public void Merge(TerraformObjectExpression other)
    {
        foreach (var (key, value) in other._properties)
        {
            _properties[key] = value;
        }
    }

    /// <summary>
    /// Creates a new TerraformObject from key-value pairs.
    /// </summary>
    public static TerraformObjectExpression FromPairs(params (string Key, object Value)[] pairs)
    {
        var obj = new TerraformObjectExpression();
        foreach (var (key, value) in pairs)
        {
            obj.Add(key, value);
        }
        return obj;
    }

    /// <summary>
    /// Implicit conversion from Dictionary to TerraformObject.
    /// </summary>
    public static implicit operator TerraformObjectExpression(Dictionary<string, TerraformExpression> dict)
    {
        var obj = new TerraformObjectExpression();
        foreach (var (key, value) in dict)
        {
            obj[key] = value;
        }
        return obj;
    }

    #endregion

    #region Two-Phase Resolution

    /// <summary>
    /// Preparation phase - prepares all nested expressions and records dependencies for references.
    /// </summary>
    public override void Prepare(ITerraformContext context)
    {
        // Prepare any nested resolvable expressions
        foreach (var (_, expr) in _properties)
        {
            expr.Prepare(context);
        }
    }

    /// <summary>
    /// Converts the object to HCL syntax with proper indentation.
    /// Uses context for indentation when available.
    /// </summary>
    public override string Resolve(ITerraformContext? context = null)
    {
        if (_properties.Count == 0)
        {
            return "{}";
        }
        context ??= TerraformContext.Temporary(this);

        var sb = new System.Text.StringBuilder();
        sb.AppendLine("{");

        using (context.PushIndent())
        {
            WriteProperties(sb, context);
        }
        sb.Append($"{context.Indent}}}");

        return sb.ToString();
    }

    protected virtual void WriteProperties(System.Text.StringBuilder sb, ITerraformContext context)
    {
        foreach (var (key, value) in _properties.OrderBy(p => p.Key))
        {
            sb.AppendLine($"{context.Indent}{key}{base.AssignmentOperator}{value.ToHcl(context)}");
        }
    }

    #endregion
}
