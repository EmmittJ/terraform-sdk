namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Base class for Terraform nested configuration blocks.
/// Blocks are structural elements that contain properties, distinct from attributes.
/// Examples: ebs_block_device, network_interface, lifecycle block.
/// </summary>
/// <remarks>
/// Blocks vs Attributes:
/// - Blocks are configuration structure (rendered as nested objects)
/// - Attributes are property values (rendered as key = value)
///
/// Blocks can contain:
/// - TerraformProperty&lt;T&gt; for simple attributes
/// - List/HashSet/Dictionary of properties for collection attributes
/// - Other TerraformBlock instances for nested blocks
/// </remarks>
public abstract class TerraformBlock : ITerraformResolvable<TerraformExpression>
{
    private readonly TerraformPropertyCollection _properties = new();
    private readonly TerraformOutputCollection _outputs = new();

    /// <summary>
    /// Sets a property value with optional priority for ordering.
    /// </summary>
    public void SetProperty(string key, object? value, int? priority = null)
    {
        _properties.Set(key, value, priority);
    }

    /// <summary>
    /// Sets a property value with optional priority for ordering.
    /// </summary>
    public TerraformBlock WithProperty(string key, object? value, int? priority = null)
    {
        SetProperty(key, value, priority);
        return this;
    }

    /// <summary>
    /// Marks a property as an output that can be referenced.
    /// </summary>
    protected void SetOutput(string key)
    {
        _outputs.Add(key);
    }

    /// <summary>
    /// Gets a property value as a specific type.
    /// </summary>
    protected T? GetProperty<T>(string key)
        => _properties.Get<T>(key);

    /// <summary>
    /// Gets a required property value as a specific type.
    /// Throws if the property is null.
    /// </summary>
    /// <exception cref="InvalidOperationException">Thrown when the property value is null.</exception>
    protected T GetRequiredProperty<T>(string key)
        => _properties.GetRequired<T>(key);

    /// <summary>
    /// Gets an output value as a specific type.
    /// </summary>
    protected T GetRequiredOutput<T>(string key)
    {
        if (!_outputs.Contains(key))
        {
            throw new InvalidOperationException($"Output '{key}' is not registered. Call SetOutput in the constructor.");
        }
        return _properties.GetRequired<T>(key);
    }

    /// <summary>
    /// Prepares all nested properties and values for resolution.
    /// Delegates to TerraformValueResolver for consistent handling.
    /// </summary>
    public virtual void Prepare(ITerraformContext context)
    {
        foreach (var value in _properties.GetValues())
        {
            TerraformValueResolver.PrepareValue(value, context);
        }
    }

    /// <summary>
    /// Resolves the block to a TerraformExpression (map/object).
    /// Properties are rendered in priority order, then alphabetically.
    /// Delegates to TerraformValueResolver for consistent value resolution.
    /// </summary>
    public virtual TerraformExpression Resolve(ITerraformContext? context = null)
    {
        var map = new TerraformMapExpression();

        foreach (var (key, value) in _properties.GetOrderedProperties())
        {
            map[key] = TerraformValueResolver.ResolveValue(value, context);
        }

        return map;
    }
}
