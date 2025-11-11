namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Base class for Terraform nested block objects.
/// Provides property storage infrastructure similar to TerraformConstruct.
/// All generated block classes should inherit from this.
/// </summary>
public abstract class TerraformBlockBase : ITerraformBlockStorage
{
    /// <summary>
    /// Internal storage for property values set by users via source-generated setters.
    /// Key = Terraform property name (e.g., "name", "location")
    /// Value = TerraformValue&lt;T&gt;, TerraformList&lt;T&gt;, TerraformMap&lt;T&gt;, etc.
    /// </summary>
    private readonly Dictionary<string, object?> _propertyValues = new();

    /// <summary>
    /// Called by source-generated property setters to store values.
    /// </summary>
    /// <param name="terraformName">The Terraform property name (from [TerraformProperty("name")] attribute).</param>
    /// <param name="value">The value to store.</param>
    protected void SetPropertyValue(string terraformName, object? value)
    {
        _propertyValues[terraformName] = value;
    }

    /// <summary>
    /// Called by source-generated property getters to retrieve stored values.
    /// Returns null if the property was never set.
    /// </summary>
    /// <typeparam name="T">The property type.</typeparam>
    /// <param name="terraformName">The Terraform property name.</param>
    /// <returns>The stored value or null.</returns>
    protected T? GetPropertyValue<T>(string terraformName)
    {
        return _propertyValues.TryGetValue(terraformName, out var value) && value is T ret
            ? ret
            : default;
    }

    /// <summary>
    /// Called by source-generated property getters for required properties.
    /// Throws if the property was never set.
    /// </summary>
    /// <typeparam name="T">The property type.</typeparam>
    /// <param name="terraformName">The Terraform property name.</param>
    /// <returns>The stored value.</returns>
    /// <exception cref="InvalidOperationException">Thrown when a required property has not been set.</exception>
    protected T GetRequiredPropertyValue<T>(string terraformName)
    {
        return GetPropertyValue<T>(terraformName) ?? throw new InvalidOperationException($"Required property '{terraformName}' has not been set.");
    }

    /// <inheritdoc/>
    public IReadOnlyDictionary<string, object?> GetPropertyValues() => _propertyValues;
}
