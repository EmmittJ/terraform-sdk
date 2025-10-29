namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Abstract base class for all Terraform constructs (resources, data sources, providers, locals).
/// Provides common property management and HCL generation infrastructure.
/// Implements ITerraformResolvable for two-pass resolution support.
/// </summary>
public abstract class TerraformConstruct : ITerraformConstruct, ITerraformResolvable
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

    /// <summary>
    /// Preparation phase - prepares all nested values and expressions.
    /// </summary>
    public virtual void Prepare(ITerraformContext context)
    {
        foreach (var value in _properties.Values)
        {
            value.Prepare(context);
        }
    }

    /// <summary>
    /// Resolution phase - generates HCL string with optional context.
    /// When context is provided, uses it for dependency tracking.
    /// When context is null, creates a temporary context.
    /// </summary>
    public abstract string Resolve(ITerraformContext? context = null);
}
