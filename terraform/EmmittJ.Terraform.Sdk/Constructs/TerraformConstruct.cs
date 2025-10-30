namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Abstract base class for all Terraform constructs (resources, data sources, providers, locals).
/// Provides common property management and HCL generation infrastructure.
/// Implements ITerraformResolvable for two-pass resolution support.
/// </summary>
public abstract class TerraformConstruct : ITerraformResolvable<string>
{
    private readonly Dictionary<string, TerraformProperty> _properties = [];

    /// <summary>
    /// Internal setter for property accessors and extension methods.
    /// Supports null to remove properties.
    /// </summary>
    internal void WithPropertyInternal(string key, TerraformProperty? value)
    {
        if (value == null)
            _properties.Remove(key);
        else
            _properties[key] = value;
    }

    /// <summary>
    /// Gets a property value (for derived classes).
    /// </summary>
    internal TerraformProperty? GetProperty(string key)
    {
        return _properties.TryGetValue(key, out var value) ? value : null;
    }

    /// <summary>
    /// Gets the properties dictionary for subclasses to use in HCL generation.
    /// </summary>
    protected IReadOnlyDictionary<string, TerraformProperty> Properties => _properties;

    /// <summary>
    /// Writes properties to HCL with proper formatting.
    /// Properties are written in alphabetical order for consistency.
    /// </summary>
    /// <param name="sb">The StringBuilder to append to.</param>
    /// <param name="context">The context for indentation and resolution.</param>
    protected void WriteProperties(System.Text.StringBuilder sb, ITerraformContext context)
    {
        foreach (var (key, property) in Properties.OrderBy(p => p.Key))
        {
            var expression = property.ToExpression();

            // Check if this is a block (nested block syntax without '=')
            if (expression is TerraformBlockExpression block)
            {
                // Don't push indent - block.ToHcl() will handle its own indentation
                sb.AppendLine($"{context.Indent}{key} {block.ToHcl(context)}");
            }
            else
            {
                // Standard property assignment with '='
                var hcl = property.Resolve(context);
                sb.AppendLine($"{context.Indent}{key} = {hcl}");
            }
        }
    }

    /// <inheritdoc/>
    public abstract TerraformExpression AsReference();

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


