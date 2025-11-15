namespace EmmittJ.Terraform.Sdk;

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

/// <summary>
/// Represents a Terraform map with string keys and expression values.
/// Provides an ergonomic API for building HCL maps without TerraformSyntaxNode.Raw.
/// Similar to BicepDictionary in Azure.Provisioning.
/// Supports collection initializer syntax and standard dictionary interfaces.
/// </summary>
public class TerraformMapExpression : TerraformExpression,
    IDictionary<string, TerraformSyntaxNode>,
    IDictionary,
    IReadOnlyDictionary<string, TerraformSyntaxNode>
{
    protected readonly Dictionary<string, TerraformSyntaxNode> _properties = new();

    /// <summary>
    /// Creates a new empty TerraformMapExpression.
    /// </summary>
    public TerraformMapExpression() { }

    #region IDictionary<string, TerraformSyntaxNode> Implementation

    /// <summary>
    /// Adds a property with a TerraformSyntaxNode value (for collection initializer syntax).
    /// </summary>
    public void Add(string key, TerraformSyntaxNode value)
    {
        _properties[key] = value ?? throw new ArgumentNullException(nameof(value));
    }

    /// <summary>
    /// Adds a property with a literal value (for collection initializer syntax).
    /// </summary>
    public void Add<T>(string key, T value)
    {
        // Redirect to expression overload if this is a TerraformSyntaxNode
        if (value is TerraformSyntaxNode expr)
        {
            Add(key, expr);
            return;
        }

        _properties[key] = Literal(value);
    }

    /// <summary>
    /// Indexer to get/set properties.
    /// </summary>
    public new TerraformSyntaxNode this[string key]
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
    public bool TryGetValue(string key, [MaybeNullWhen(false)] out TerraformSyntaxNode value)
        => _properties.TryGetValue(key, out value);

    /// <summary>
    /// Gets the keys in the dictionary.
    /// </summary>
    public ICollection<string> Keys => _properties.Keys;

    /// <summary>
    /// Gets the values in the dictionary.
    /// </summary>
    public ICollection<TerraformSyntaxNode> Values => _properties.Values;

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
    void ICollection<KeyValuePair<string, TerraformSyntaxNode>>.Add(KeyValuePair<string, TerraformSyntaxNode> item)
        => Add(item.Key, item.Value);

    /// <summary>
    /// Checks if the dictionary contains a key-value pair.
    /// </summary>
    bool ICollection<KeyValuePair<string, TerraformSyntaxNode>>.Contains(KeyValuePair<string, TerraformSyntaxNode> item)
        => ((ICollection<KeyValuePair<string, TerraformSyntaxNode>>)_properties).Contains(item);

    /// <summary>
    /// Copies the dictionary to an array.
    /// </summary>
    void ICollection<KeyValuePair<string, TerraformSyntaxNode>>.CopyTo(KeyValuePair<string, TerraformSyntaxNode>[] array, int arrayIndex)
        => ((ICollection<KeyValuePair<string, TerraformSyntaxNode>>)_properties).CopyTo(array, arrayIndex);

    /// <summary>
    /// Removes a key-value pair.
    /// </summary>
    bool ICollection<KeyValuePair<string, TerraformSyntaxNode>>.Remove(KeyValuePair<string, TerraformSyntaxNode> item)
        => ((ICollection<KeyValuePair<string, TerraformSyntaxNode>>)_properties).Remove(item);

    /// <summary>
    /// Gets the enumerator for the properties.
    /// </summary>
    public IEnumerator<KeyValuePair<string, TerraformSyntaxNode>> GetEnumerator()
        => _properties.GetEnumerator();

    /// <summary>
    /// Gets the enumerator for the properties (non-generic).
    /// </summary>
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    #endregion

    #region IReadOnlyDictionary<string, TerraformSyntaxNode> Implementation

    IEnumerable<string> IReadOnlyDictionary<string, TerraformSyntaxNode>.Keys => _properties.Keys;
    IEnumerable<TerraformSyntaxNode> IReadOnlyDictionary<string, TerraformSyntaxNode>.Values => _properties.Values;

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

            var expr = value as TerraformSyntaxNode ?? TerraformExpression.Literal(value);
            _properties[s] = expr;
        }
    }

    void IDictionary.Add(object key, object? value)
    {
        if (key is not string s)
            throw new ArgumentException("Key must be a string", nameof(key));
        if (value is null)
            throw new ArgumentNullException(nameof(value));

        var expr = value as TerraformSyntaxNode ?? TerraformExpression.Literal(value);
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
    public TerraformSyntaxNode? Get(string key)
    {
        return _properties.TryGetValue(key, out var value) ? value : null;
    }

    /// <summary>
    /// Merges another TerraformMapExpression into this one.
    /// Later values overwrite earlier ones.
    /// </summary>
    public void Merge(TerraformMapExpression other)
    {
        foreach (var (key, value) in other._properties)
        {
            _properties[key] = value;
        }
    }

    /// <summary>
    /// Creates a new TerraformMapExpression from key-value pairs.
    /// </summary>
    public static TerraformMapExpression FromPairs(params (string Key, object Value)[] pairs)
    {
        var obj = new TerraformMapExpression();
        foreach (var (key, value) in pairs)
        {
            obj.Add(key, value);
        }
        return obj;
    }

    /// <summary>
    /// Implicit conversion from Dictionary to TerraformMapExpression.
    /// </summary>
    public static implicit operator TerraformMapExpression(Dictionary<string, TerraformSyntaxNode> dict)
    {
        var obj = new TerraformMapExpression();
        foreach (var (key, value) in dict)
        {
            obj[key] = value;
        }
        return obj;
    }

    #endregion

    #region HCL Rendering

    /// <summary>
    /// Converts the object to HCL syntax with proper indentation.
    /// Uses context for indentation when available.
    /// </summary>
    public override string ToHcl(ITerraformContext context)
    {
        if (_properties.Count == 0)
        {
            return "{}";
        }

        var sb = new System.Text.StringBuilder();
        sb.AppendLine("{");

        using (context.PushIndent())
        {
            sb.Append(RenderProperties(context));
        }
        sb.Append($"{context.Indent}}}");

        return sb.ToString();
    }

    /// <summary>
    /// Renders the properties as HCL with proper indentation.
    /// Returns the rendered properties without surrounding braces, allowing parent expressions
    /// to compose the content within their own block structures.
    /// Dynamic block expressions are rendered as standalone blocks (not as key = value assignments).
    /// </summary>
    /// <param name="context">The rendering context providing indentation and scope information.</param>
    /// <returns>The rendered properties as a string.</returns>
    protected internal virtual string RenderProperties(ITerraformContext context)
    {
        var sb = new System.Text.StringBuilder();

        foreach (var (key, value) in _properties.OrderBy(p => p.Key))
        {
            // Dynamic blocks are structural nodes, not value expressions - render as blocks
            if (value is TerraformDynamicBlockNode dynamicBlockNode)
            {
                sb.AppendLine(dynamicBlockNode.ToHcl(context));
            }
            // All other values are expressions that can be rendered as arguments
            else if (value is TerraformExpression expr)
            {
                sb.AppendLine($"{context.Indent}{key} = {expr.ToHcl(context)}");
            }
            else
            {
                // Other syntax nodes that aren't expressions
                sb.AppendLine($"{context.Indent}{key} = {value.ToHcl(context)}");
            }
        }

        return sb.ToString();
    }

    #endregion
}
