namespace EmmittJ.Terraform.Sdk;

using System.Collections;

/// <summary>
/// Represents a Terraform object/map with string keys and expression values.
/// Provides an ergonomic API for building HCL objects without TerraformExpression.Raw.
/// Similar to BicepDictionary in Azure.Provisioning.
/// Supports collection initializer syntax.
/// </summary>
public class TerraformObject : TerraformExpression, IEnumerable
{
    protected readonly Dictionary<string, TerraformExpression> _properties = new();

    /// <summary>
    /// Creates a new empty TerraformObject.
    /// </summary>
    public TerraformObject() { }

    /// <summary>
    /// Sets a property with a TerraformExpression value.
    /// </summary>
    public TerraformObject Set(string key, TerraformExpression value)
    {
        _properties[key] = value ?? throw new ArgumentNullException(nameof(value));
        return this;
    }

    /// <summary>
    /// Sets a property with a literal value (string, number, bool, etc.).
    /// </summary>
    public TerraformObject Set<T>(string key, T value)
    {
        _properties[key] = Literal(value);
        return this;
    }

    /// <summary>
    /// Sets a property with a reference value.
    /// </summary>
    public TerraformObject Set(string key, TerraformReference reference)
    {
        _properties[key] = reference?.ToExpression() ?? throw new ArgumentNullException(nameof(reference));
        return this;
    }

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
    /// Adds a property with a reference value (for collection initializer syntax).
    /// </summary>
    public void Add(string key, TerraformReference reference)
    {
        _properties[key] = reference?.ToExpression() ?? throw new ArgumentNullException(nameof(reference));
    }

    /// <summary>
    /// Gets a property value.
    /// </summary>
    public TerraformExpression? Get(string key)
    {
        return _properties.TryGetValue(key, out var value) ? value : null;
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
    /// Gets the number of properties.
    /// </summary>
    public int Count => _properties.Count;

    /// <summary>
    /// Converts the object to HCL syntax with proper indentation.
    /// Uses context for indentation when available.
    /// </summary>
    public override string ToHcl(ITerraformContext? context = null)
    {
        if (_properties.Count == 0)
        {
            return "{}";
        }

        var currentIndent = context?.Indent ?? "";
        var nextIndent = currentIndent + "  ";

        var sb = new System.Text.StringBuilder();
        sb.AppendLine("{");
        foreach (var (key, value) in _properties)
        {
            sb.AppendLine($"{nextIndent}{key} = {value.ToHcl(context)}");
        }
        sb.Append($"{currentIndent}}}");

        return sb.ToString();
    }

    /// <summary>
    /// Merges another TerraformObject into this one.
    /// Later values overwrite earlier ones.
    /// </summary>
    public TerraformObject Merge(TerraformObject other)
    {
        foreach (var (key, value) in other._properties)
        {
            _properties[key] = value;
        }
        return this;
    }

    /// <summary>
    /// Creates a new TerraformObject from key-value pairs.
    /// </summary>
    public static TerraformObject FromPairs(params (string Key, object Value)[] pairs)
    {
        var obj = new TerraformObject();
        foreach (var (key, value) in pairs)
        {
            if (value is TerraformExpression expr)
                obj.Set(key, expr);
            else if (value is TerraformReference refr)
                obj.Set(key, refr);
            else
                obj.Set(key, value);
        }
        return obj;
    }

    /// <summary>
    /// Implicit conversion from Dictionary to TerraformObject.
    /// </summary>
    public static implicit operator TerraformObject(Dictionary<string, TerraformExpression> dict)
    {
        var obj = new TerraformObject();
        foreach (var (key, value) in dict)
        {
            obj.Set(key, value);
        }
        return obj;
    }

    /// <summary>
    /// Gets the enumerator for the properties (required for collection initializer).
    /// </summary>
    public IEnumerator GetEnumerator() => _properties.GetEnumerator();
}
