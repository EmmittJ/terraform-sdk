namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Abstract base class for all Terraform constructs (resources, data sources, providers, locals).
/// Provides common property management and HCL generation infrastructure.
/// </summary>
public abstract class TerraformConstruct : ITerraformConstruct
{
    private readonly Dictionary<string, ITerraformValue> _properties = [];

    /// <summary>
    /// Gets a property value.
    /// </summary>
    public TerraformValue<T> GetInternal<T>(string propertyName)
    {
        if (_properties.TryGetValue(propertyName, out var value) && value is TerraformValue<T> typed)
        {
            return typed;
        }
        return new TerraformValue<T>();
    }

    /// <summary>
    /// Sets a property value.
    /// </summary>
    public void SetInternal(string propertyName, ITerraformValue value)
    {
        _properties[propertyName] = value;
    }

    /// <summary>
    /// Gets the properties dictionary for subclasses to use in HCL generation.
    /// </summary>
    protected IReadOnlyDictionary<string, ITerraformValue> Properties => _properties;

    /// <inheritdoc/>
    public abstract TerraformExpression GetReferenceExpression();

    /// <inheritdoc/>
    public abstract string ToHcl(int indent = 0);
}
